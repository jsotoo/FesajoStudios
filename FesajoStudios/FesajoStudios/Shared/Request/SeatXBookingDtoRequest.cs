using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Shared.Request
{
    public class SeatXBookingDtoRequest
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public int SeatId { get; set; }
    }
}
