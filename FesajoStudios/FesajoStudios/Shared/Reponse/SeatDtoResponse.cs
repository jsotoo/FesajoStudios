using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FesajoStudios.Shared.Reponse
{
    [DataContract]
    public class SeatDtoResponse
    {
        [JsonPropertyName("id")]
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [JsonPropertyName("seatCode")]
        [DataMember(Name = "seatCode")]
        public string SeatCode { get; set; } = default!;
        [JsonPropertyName("seatType")]
        [DataMember(Name = "seatType")]
        public string SeatType { get; set; } = default!;
        [JsonPropertyName("seatTypeId")]
        [DataMember(Name = "seatTypeId")]
        public int SeatTypeId { get; set; }
        [JsonPropertyName("showing")]
        [DataMember(Name = "showing")]
        public string Showing { get; set; } = default!;
        [JsonPropertyName("showingId")]
        [DataMember(Name = "showingId")]
        public int ShowingId { get; set; }
    }
}
