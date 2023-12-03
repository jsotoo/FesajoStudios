using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Shared.Request
{
    public class TicketDtoRequest
    {
        public int Id { get; set; }
        public int TicketTypeId { get; set; }
        public decimal Price { get; set; }
        public int ShowingId { get; set; }
    }
}
