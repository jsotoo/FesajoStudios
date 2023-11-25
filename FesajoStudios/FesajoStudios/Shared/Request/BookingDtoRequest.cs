using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Shared.Request
{
    public class BookingDtoRequest
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public string? BookingType { get; set; }
        public int BookingTypeId { get; set; }
        public string? Showing { get; set; }
        public int ShowingId { get; set; }
        public string? Client { get; set; }
        public int ClientId { get; set; }

    }
}
