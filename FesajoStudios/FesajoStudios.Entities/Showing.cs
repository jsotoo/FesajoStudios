using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Entities
{
    public class Showing : EntityBase
    {
 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        //Relaciones uno a muchos
        public Movie Movie { get; set; } = default!;
        public int MovieId { get; set; }

        public Theather Theather { get; set; } = default!;
        public int TheatherId { get; set; }


    }
}
