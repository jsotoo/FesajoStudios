using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Entities
{
    public class Seat : EntityBase
    {
        public string SeatCode { get; set; } = default!;

        public SeatType SeatType { get; set; } = default!;

        public int SeatTypeId { get; set; }

        //Relacion uno a muchos

        public Showing Showing { get; set; } = default!;
        public int ShowingId { get; set;}


    }
}
