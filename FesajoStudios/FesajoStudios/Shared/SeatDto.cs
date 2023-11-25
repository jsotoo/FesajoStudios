using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Shared
{
    public class SeatDto
    {
        public int Id { get; set; }
        public string SeatCode { get; set; } = default!;

        public string SeatType { get; set; } = default!;
        public int SeatTypeId { get; set; }

        public string Showing { get; set; } = default!;
        public int ShowingId { get; set; }
    }
}
