using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FesajoStudios.Shared.Reponse
{
   
    public class ShowingDtoResponse
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MovieId { get; set; }
        public int TheatherId { get; set; }
        public string Movie { get; set; } = default!;
        public string Theather { get; set; } = default!;
    }
}
