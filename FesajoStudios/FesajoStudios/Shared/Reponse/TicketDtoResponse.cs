using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Shared.Reponse
{
    public class TicketDtoResponse
    {
        public int Id { get; set; }
        public string? TicketType { get; set; }
        public int TicketTypeId { get; set; }
        public decimal Price { get; set; }
        public string? Showing { get; set; }
        public int ShowingId { get; set; }
    }
}
