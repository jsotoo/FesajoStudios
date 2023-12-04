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
        [Required(ErrorMessage = "El nombre de la sala es obligatorio.")]
        public string Name { get; set; } = default!;
        
        [Required(ErrorMessage = "La capacidad o cantidad de sillas de la sala es obligatorio.")]
        public int Capacity { get; set; }

    }
}
