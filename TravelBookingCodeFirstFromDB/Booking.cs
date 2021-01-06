namespace TravelBookingCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        public int BookingId { get; set; }

        public int ClientId { get; set; }

        public int FlightId { get; set; }

        public virtual Client Client { get; set; }

        public virtual Flight Flight { get; set; }
    }
}
