using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Shared
{
    public class TheatherDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = default!;
        [Required]
        public int Capacity { get; set; }

    }
}
