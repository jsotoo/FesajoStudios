using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Entities
{
    public class Ticket : EntityBase
    {
        public TicketType TicketType { get; set; } = default!;
        public int TicketTypeId { get; set; }

        public decimal Price { get; set; }

        public Showing Showing { get; set; } = default!;
        public int ShowingId { get; set; }
    }
}
