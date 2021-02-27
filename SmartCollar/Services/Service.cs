using Microsoft.EntityFrameworkCore;
using SmartCollar.Data;
using SmartCollar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCollar.Services
{
    public class Service : IService
    {
        private readonly ApplicationDbContext _context;
        public ApplicationDbContext GetContext() => _context;

        public Service(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Notification> GetNotifications()
        {
            return _context.Notifications.Include(s => s.Collar).Include(s => s.UserObservations).ThenInclude(s => s.User).Take(50);
        }

        public void UpdateNotification(Notification notification)
        {
            var dbNotification = _context.Notifications.Find(notification.NotificationId);
            if (dbNotification == null)
            {
                dbNotification = notification;
                dbNotification.CreatedAt = DateTime.Now;
                dbNotification.UpdatedAt = DateTime.Now;
                _context.Notifications.Add(dbNotification);
            }
            else
            {
                dbNotification.UpdatedAt = DateTime.Now;
                if (notification.UserObservations.Any())
                {
                    notification.UserObservations.First().CreatedAt = DateTime.Now;
                    _context.UserNotifications.AddRange(notification.UserObservations);
                }
            }
            _context.SaveChanges();
        }

        public string Login(string user, string hash)
        {
            throw new NotImplementedException();
        }

        public bool Register(string user, string hash, string name)
        {
            throw new NotImplementedException();
        }

        public bool Logout(string user, string token)
        {
            throw new NotImplementedException();
        }
    }
}
