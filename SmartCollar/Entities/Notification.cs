using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCollar.Entities
{
    public class Notification : TrackableRegister
    {
        [Key]
        public Guid NotificationId { get; set; }

        public DateTime Time { get; set; }

        public string TimeString { get => Time.ToString("dd/MM/yyyy hh:mm"); }

        public string LastUpdateString { get => LastUpdate?.ToString("dd/MM/yyyy hh:mm"); }

        public DateTime? LastUpdate { get => UserObservations.OrderBy(b => b.CreatedAt).LastOrDefault()?.CreatedAt; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public decimal LocationPrecision { get; set; }

        public string DeviceId { get; set; }

        public Collar Collar { get; set; }

        public virtual IEnumerable<UserNotification> UserObservations { get; set; }

        public string LastObservation { get => UserObservations?.OrderBy(s => s.CreatedAt)?.LastOrDefault()?.Text ?? ""; }
    }
}
