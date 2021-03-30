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
		private readonly Random random = new Random();
		public ApplicationDbContext GetContext() => _context;

		public Service(ApplicationDbContext context) {
			_context = context;
		}

		public IEnumerable<Notification> GetNotifications() {
			return _context.Notifications.Include(s => s.Collar).Include(s => s.UserObservations).ThenInclude(s => s.User).Take(50);
		}

		public void UpdateNotification(Notification notification) {
			var dbNotification = _context.Notifications.Find(notification.NotificationId);
			if (dbNotification == null) {
				dbNotification = notification;
				dbNotification.CreatedAt = DateTime.Now;
				dbNotification.UpdatedAt = DateTime.Now;
				_context.Notifications.Add(dbNotification);
			} else {
				dbNotification.UpdatedAt = DateTime.Now;
				if (notification.UserObservations.Any()) {
					notification.UserObservations.First().CreatedAt = DateTime.Now;
					_context.UserNotifications.AddRange(notification.UserObservations);
				}
			}
			_context.SaveChanges();
		}
		public string RandomString(int length) {
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, length)
			  .Select(s => s[random.Next(s.Length)]).ToArray());
		}

		public string Login(string userName, string hash) {
			var user = _context.MobileUsers.FirstOrDefault(u => u.UserName == userName && u.Hash == hash);
			if (user == null) {
				return null;
			} else {
				user.Token = RandomString(12);
				_context.SaveChanges();
				return user.Token;
			}
		}

		public bool Register(string userName, string hash, string name) {
			if (_context.MobileUsers.Any(u => u.UserName == userName)) {
				return false;
			}
			var user = new MobileUser {
				Hash = hash,
				Name = name,
				UserName = userName
			};
			_context.MobileUsers.Add(user);
			_context.SaveChanges();
			return true;
		}

		public bool Logout(string userName, string token) {
			var user = _context.MobileUsers.FirstOrDefault(u => u.UserName == userName && u.Token == token);
			if (user == null)
				return false;
			else {
				user.Token = null;
				_context.SaveChanges();
				return true;
			}
		}
	}
}
