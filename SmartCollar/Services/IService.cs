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
    }
}
