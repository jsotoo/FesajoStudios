using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FesajoStudios.Shared.Reponse
{

    public class BookingDtoResponse
    {

        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public int BookingTypeId { get; set; }
        public string? BookingType { get; set; }
        public int ShowingId { get; set; }
        public string? Showing { get; set; }
        public int ClientId { get; set; }
        public string? Client { get; set;}

        public string? movieImage { get; set; }

        public int TheatherId { get; set; }

        public decimal Total { get; set; }
    }
}
