using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Shared
{
    public class ShowingDto
    {
        public int Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int MovieId { get; set; }
        [Required]
        public int TheatherId { get; set; }

        public string Movie { get; set; } = default!;
        public string Theather { get; set; } = default!;



    }
}
