using SmartCollar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCollar.Services
{
    public class Service : IService
    {
        public IEnumerable<Notification> GetNotifications()
        {
            var collar1 = new Collar
            {
                DeviceId = "collar-1",
                LastTimeSeen = new DateTime(2021, 2, 05),
                Latitude = 20,
                LocationPrecision = 10,
                Longitude = 5
            };
            return new Notification[]
            {
                new Notification
                {
                    NotificationId = 0,
                    UserObservation = "Cachorro muito bravo, cuidado!",
                    Collar = collar1,
                    DeviceId = "collar-1",
                    Latitude = -3.744253M,
                    LocationPrecision = 12,
                    Longitude = -38.574700M,
                    Time = new DateTime(2021, 1, 31)
                },
                new Notification
                {
                    NotificationId = 1,
                    UserObservation = "Cachorro manso, latiu só de chato.",
                    Collar = collar1,
                    DeviceId = "collar-1",
                    Latitude = -3.741185M,
                    LocationPrecision = 15,
                    Longitude = 38.574827M,
                    Time = new DateTime(2021, 2, 1)
                },
                new Notification
                {
                    NotificationId = 2,
                    UserObservation = "Cachorro manso, latiu só de chato.",
                    Collar = collar1,
                    DeviceId = "collar-1",
                    Latitude = -3.744311M,
                    LocationPrecision = 15,
                    Longitude = -38.576603M,
                    Time = new DateTime(2021, 2, 1)
                },
                new Notification
                {
                    NotificationId = 3,
                    UserObservation = "Cachorro manso, latiu só de chato.",
                    Collar = collar1,
                    DeviceId = "collar-1",
                    Latitude = -3.744311M,
                    LocationPrecision = 15,
                    Longitude = -38.576603M,
                    Time = new DateTime(2021, 2, 1)
                },
                new Notification
                {
                    NotificationId = 4,
                    UserObservation = "Cachorro manso, latiu só de chato.",
                    Collar = collar1,
                    DeviceId = "collar-1",
                    Latitude = -3.744411M,
                    LocationPrecision = 15,
                    Longitude = -38.571603M,
                    Time = new DateTime(2021, 2, 2)
                },
                new Notification
                {
                    NotificationId = 5,
                    UserObservation = "Cachorro manso, latiu só de chato.",
                    Collar = collar1,
                    DeviceId = "collar-1",
                    Latitude = -3.744111M,
                    LocationPrecision = 15,
                    Longitude = -38.578603M,
                    Time = new DateTime(2021, 2, 2)
                },
                new Notification
                {
                    NotificationId = 6,
                    UserObservation = "Cachorro manso, latiu só de chato.",
                    Collar = collar1,
                    DeviceId = "collar-1",
                    Latitude = -3.744511M,
                    LocationPrecision = 15,
                    Longitude = -38.575603M,
                    Time = new DateTime(2021, 2, 4)
                },
                new Notification
                {
                    NotificationId = 7,
                    UserObservation = "Cachorro manso, latiu só de chato.",
                    Collar = collar1,
                    DeviceId = "collar-1",
                    Latitude = -3.744550M,
                    LocationPrecision = 15,
                    Longitude = -38.575013M,
                    Time = new DateTime(2021, 2, 4)
                }
            };
        }
    }
}
