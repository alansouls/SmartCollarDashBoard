using SmartCollar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCollar.Data
{
    public class DataSeed
    {
        private readonly Random _random;
        private  IEnumerable<Collar> _collars;
        private IEnumerable<MobileUser> _users;
        private IEnumerable<UserNotification> _userNotifications;
        private IEnumerable<Notification> _notifications;

        private const decimal latitudeMax = -3.740m;
        private const decimal longitudeMax = -38.570m;
        private const decimal latitudeMin = -3.749m;
        private const decimal longitudeMin = -38.579m;

        private readonly string[] namesList = { "Alan", "Eduardo", "Lucas", "João", "Carlos", "José", "Maria", "Luana", "Joana", "Francisca" };
        private readonly string[] observationList = { "Cachorro não atacou, alarme falso", "Cachorro muito bravo, tome cuidado", "Não vi cachorro nenhum, deve ter sido um bug", "Vi o cachorro, mas ele não latiu, acho que bugou" };

        public IEnumerable<Collar> Collars { get => _collars; }
        public IEnumerable<MobileUser> Users { get => _users; }
        public IEnumerable<UserNotification> UserNotifications { get => _userNotifications; }
        public IEnumerable<Notification> Notifications { get => _notifications; }

        public DataSeed()
        {
            _random = new Random();
            _collars = GenerateCollars();
            _users = GenerateUsers();
            _notifications = GenerateNotifications();
            _userNotifications = GenerateUserNotifications();
        }

        private IEnumerable<Collar> GenerateCollars()
        {
            var list = new List<Collar>();
            for (var i = 0; i < 5; ++i)
            {
                decimal latitude = (decimal)(latitudeMin + (latitudeMax - latitudeMin) * (decimal)_random.NextDouble());
                decimal longitude = (decimal)(longitudeMin + (longitudeMax - longitudeMin) * (decimal)_random.NextDouble());
                var id = i == 0 ? "6008ccff9da25300273d88bd" : i.ToString();
                list.Add(new Collar
                {
                    DeviceId = id,
                    LastTimeSeen = DateTime.Now.AddHours(-_random.Next(50)),
                    Latitude = latitude,
                    Longitude = longitude,
                    LocationPrecision = 10,
                });
            }

            return list;
        }
        private IEnumerable<Notification> GenerateNotifications()
        {
            var list = new List<Notification>();
            foreach (var collar in _collars)
            {
                for (var i = 0; i < 20; ++i)
                {
                    decimal latitude = latitudeMin + (latitudeMax - latitudeMin) * (decimal)_random.NextDouble();
                    decimal longitude = longitudeMin + (longitudeMax - longitudeMin) * (decimal)_random.NextDouble();
                    int creationOffset = _random.Next(50);
                    list.Add(new Notification
                    {
                        DeviceId = collar.DeviceId,
                        CreatedAt = DateTime.Now.AddHours(-creationOffset),
                        UpdatedAt = DateTime.Now.AddHours(-_random.Next(creationOffset)),
                        Latitude = latitude,
                        Longitude = longitude,
                        LocationPrecision = 10,
                        Time = DateTime.Now.AddHours(-creationOffset),
                        NotificationId = Guid.NewGuid(),
                    });
                }
            }

            return list;
        }

        private IEnumerable<MobileUser> GenerateUsers()
        {
            var list = new List<MobileUser>();
                for (var i = 0; i < 10; ++i)
                {
                    list.Add(new MobileUser
                    {
                        Hash = "1234",
                        Id = Guid.NewGuid(),
                        Name = namesList[i],
                        Token = "",
                        UserName = namesList[i]
                    });
                }
            return list;
        }

        private IEnumerable<UserNotification> GenerateUserNotifications()
        {
            var list = new List<UserNotification>();
            foreach (var u in _users)
            {
                foreach (var n in _notifications)
                {
                    int creationOffset = _random.Next(50);
                    list.Add(new UserNotification
                    {
                        CreatedAt = DateTime.Now.AddHours(-creationOffset),
                        UpdatedAt = DateTime.Now.AddHours(_random.Next(creationOffset)),
                        NotificationId = n.NotificationId,
                        Text = observationList[_random.Next(4)],
                        UserId = u.Id,
                        WasAnAttack = _random.NextDouble() > 0.5 ? true : false
                    });
                }
            }
            return list;
        }
    }
}
