using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCollar.Entities
{
    public class Collar
    {
        [Key]
        public string DeviceId { get; set; }

        public DateTime LastTimeSeen { get; set; }
        public string LastTimeSeenString { get => LastTimeSeen.ToString("dd/MM/yyyy hh:mm"); }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public decimal LocationPrecision { get; set; }

        public IEnumerable<Notification> Notifications { get; set; }
    }
}
