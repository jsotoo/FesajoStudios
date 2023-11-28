using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Shared.Reponse
{
    public class SeatXBookingDtoResponse
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public string? Seat { get; set; }
        public int SeatId { get; set; }
    }
}
