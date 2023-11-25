using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Shared
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = default!;
        [Required]
        public string Description { get; set; } = default!;
        [Required]
        public TimeSpan Duration { get; set; }
        [Required]
        public string Rating { get; set; } = default!;
        [Required]
        public string Director { get; set; } = default!;
        [Required]
        public string Genre { get; set; } = default!;
        [Required]
        public DateTime ReleaseDate { get; set; }
        
        public string? Base64Image { get; set; }
    
        public string? NameFile { get; set; }
        public string? UrlImage { get; set; }

    }
}
