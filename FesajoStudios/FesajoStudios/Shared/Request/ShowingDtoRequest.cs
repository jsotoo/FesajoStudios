using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Shared.Request
{
    public class ShowingDtoRequest
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "La fecha de inicio es obligatoria.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "La fecha de fin es obligatoria.")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "La película es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "Seleccione una película válida.")]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "La sala de cine es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "Seleccione una sala de cine válida.")]
        public int TheatherId { get; set; }
    }
}
