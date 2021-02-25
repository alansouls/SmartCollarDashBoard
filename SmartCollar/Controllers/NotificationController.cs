using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        [HttpPost("[action]")]
        public IActionResult UpdateNotification(Notification notification)
        {
            _service.UpdateNotification(notification);
            return Ok();
        }
    }
}
