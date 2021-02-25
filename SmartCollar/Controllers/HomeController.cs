using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartCollar.Extentions;
using SmartCollar.Models;
using SmartCollar.Services;

namespace SmartCollar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IService _service;

        public HomeController(ILogger<HomeController> logger, IService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetNotifications()
        {
            var notifications = _service.GetNotifications();
            var dto = notifications.Select(n => new
            {
                n.Latitude,
                n.Longitude,
                Precision = n.LocationPrecision,
                n.TimeString,
                n.Collar.LastTimeSeenString,
                n.LastObservation
            }).ToList();

            return Json(dto);
        }

        public IActionResult GetNotificationsMapLocations()
        {
            var notifications = _service.GetNotifications();
            var dto = notifications.Select(n => new
            {
                Location = new decimal[] { n.Latitude, n.Longitude },
                Value = 100000M
            }).ToList();

            return Json(dto);
        }

        public IActionResult GetNotificationsTimeHistory()
        {
            var today = DateTime.Today;
            var weekStart = today.AddDays(-(int)today.DayOfWeek);
            var weekEnd = weekStart.AddDays(6);
            var notifications = _service.GetNotifications();
            var dto = notifications.Where(a => a.Time.Date.Between(weekStart, weekEnd)).GroupBy(a => a.Time.Date).Select(n => new
            {
                date = n.Key,
                dateString = n.Key.ToString("dd/MM/yyyy"),
                value = n.Count()
            }).OrderBy(a => a.date).ToList();

            return Json(dto);
        }
    }
}
