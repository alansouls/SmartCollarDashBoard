using System;

namespace SmartCollar.Entities
{
    public class UserNotification : TrackableRegister
    {
        public Guid UserId { get; set; }

        public Guid NotificationId { get; set; }

        public MobileUser User { get; set; }

        public Notification Notification { get; set; }

        public bool WasAnAttack { get; set; }

        public string Text { get; set; }
    }
}