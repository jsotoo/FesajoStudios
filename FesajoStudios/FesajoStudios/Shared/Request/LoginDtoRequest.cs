﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Shared.Request
{
    public class LoginDtoRequest
    {
        [Required]
        public string User { get; set; } = default!;
        [Required]
        public string Password { get; set; } = default!;
    }
}
