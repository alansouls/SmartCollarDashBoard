using System;

namespace SmartCollar.Dto
{
    public class LocationDTO
    {
        public decimal Lat { get; set; }

        public decimal Lng { get; set; }
    }
    public class ObservationDTO
    {
        public bool Confirm { get; set; }

        public string Observation { get; set; }

        public Guid User_Id { get; set; }
    }
    public class NotificationDTO
    {
        public string Device_id { get; set; }

        public Guid Notification_id { get; set; }

        public LocationDTO Location { get; set; }

        public int Accuracy { get; set; }

        public ObservationDTO Observation { get; set; }
    }
}
