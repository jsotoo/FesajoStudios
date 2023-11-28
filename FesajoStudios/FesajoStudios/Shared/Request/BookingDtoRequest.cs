using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FesajoStudios.Shared.Request
{
    public class BookingDtoRequest
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("reservationDate")]
        public DateTime ReservationDate { get; set; }

        [JsonPropertyName("bookingTypeId")]
        public int BookingTypeId { get; set; }

        [JsonPropertyName("showingId")]
        public int ShowingId { get; set; }

        [JsonPropertyName("clientId")]
        public int ClientId { get; set; }

    }
}
