using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using SmartCollar.Dto;
using SmartCollar.Entities;
using SmartCollar.Extentions;
using SmartCollar.Models;
using SmartCollar.Services;

namespace SmartCollar.Controllers
{
	[Route("api/[controller]")]
	public class NotificationController : Controller
	{
		private readonly ILogger<NotificationController> _logger;
		private readonly IService _service;

		public NotificationController(ILogger<NotificationController> logger, IService service)
		{
			_logger = logger;
			_service = service;
		}

		[HttpGet("user/{token}")]
		public IActionResult NotificationsByUser([FromRoute] string token)
		{
			var user = _service.GetUser(token);
			var notifications = _service.GetUserNotifications(user.Id).ToList();
			return Ok(notifications.Select(n => new
			{
				n.DeviceId,
				n.NotificationId,
				n.Time,
				description = n.UserObservations.FirstOrDefault(u => u.User.Token == token)?.Text ?? null,
				confirmed = n.UserObservations.FirstOrDefault(u => u.User.Token == token)?.WasAnAttack ?? null,
			}).ToList());
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> UpdateNotification()
		{
			HttpContext.Request.EnableBuffering();
			string json;
			using (var s = new StreamReader(Request.Body, Encoding.UTF8, true, 1024, true))
			{
				json = await s.ReadToEndAsync();
			}
			var notificationDto = JsonConvert.DeserializeObject<IEnumerable<NotificationDTO>>(json).FirstOrDefault();
			var notification = new Notification
			{
				DeviceId = notificationDto.Device_id,
				NotificationId = notificationDto.Notification_id,
				Latitude = notificationDto.Location?.Lat ?? 0,
				Longitude = notificationDto.Location?.Lng ?? 0,
				LocationPrecision = notificationDto.Accuracy,
				Time = DateTime.Now,
			};
			if (notificationDto.Observation != null)
			{
				var user = _service.GetUser(notificationDto.Observation.token);
				if (user == null)
					return Unauthorized();
				notification.UserObservations = new List<UserNotification>
				{
					new UserNotification
					{
						NotificationId = notificationDto.Notification_id,
						Text = notificationDto.Observation.Observation,
						UserId = user.Id,
						WasAnAttack = notificationDto.Observation.Confirm
					}
				};
			}
			_service.UpdateNotification(notification);
			return Ok();
		}
	}
}
