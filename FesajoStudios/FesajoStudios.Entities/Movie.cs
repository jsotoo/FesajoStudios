﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Entities
{
    public class Movie : EntityBase
    {
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public TimeSpan Duration { get; set; }
        public string Rating { get; set; } = default!;
        public string Director { get; set; } = default!;
        public string Genre { get; set; } = default!;
        public DateTime ReleaseDate { get; set; }
        public string? UrlImage { get; set; }


    }
}
