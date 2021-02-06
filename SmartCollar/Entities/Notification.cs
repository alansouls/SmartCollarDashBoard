using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCollar.Entities
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        public DateTime Time { get; set; }

        public string TimeString { get => Time.ToString("dd/MM/yyyy hh:mm"); }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public decimal LocationPrecision { get; set; }

        public string DeviceId { get; set; }

        public Collar Collar { get; set; }

        public string UserObservation { get; set; }
    }
}
