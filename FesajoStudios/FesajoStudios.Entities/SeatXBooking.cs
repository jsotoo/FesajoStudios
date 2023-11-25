using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Entities
{
    public class SeatXBooking: EntityBase
    {
        public Booking Booking { get; set; } = default!;
        public int BookingId { get; set; }

        public Seat Seat { get; set; } = default!;
        public int SeatId { get; set;} 


    }
}
