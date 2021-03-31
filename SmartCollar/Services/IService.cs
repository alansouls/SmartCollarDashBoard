using SmartCollar.Data;
using SmartCollar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCollar.Services
{
    public interface IService
    {
        IEnumerable<Notification> GetNotifications();

        ApplicationDbContext GetContext();

        void UpdateNotification(Notification n);

        string Login(string user, string hash);

        bool Register(string user, string hash, string name);
        bool Logout(string user, string token);
		MobileUser GetUser(string token);
		IEnumerable<Notification> GetUserNotifications(Guid userId);
	}
}
