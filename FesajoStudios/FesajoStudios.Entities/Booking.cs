using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Entities
{
    public class Booking : EntityBase
    {
        public DateTime ReservationDate { get; set; }

        public BookingType BookingType { get; set; } = default!;

        public int BookingTypeId { get; set; }

        public Showing Showing { get; set; } = default!;
        public int ShowingId { get; set; }


        public Client Client { get; set; } = default!;
        public int ClientId { get; set; }

        public decimal Total { get; set; }

    }
}
