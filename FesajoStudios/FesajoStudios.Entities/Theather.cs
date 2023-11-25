using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Entities
{
    public class Theather : EntityBase
    {
        public string Name { get; set; } = default!;
        public int Capacity { get; set; }   
    }
}
