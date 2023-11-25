using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Shared.Request
{
    public class RegisterUserDto
    {
        [Required]
        public string FullName { get; set; } = default!;

        public DateTime BirthDate { get; set; } = DateTime.Today.AddYears(-20);

        [Required]
        public string Address { get; set; } = default!;

        [Required]
        public string UserName { get; set; } = default!;

        [EmailAddress]
        public string Email { get; set; } = default!;

        [Required]
        public string Password { get; set; } = default!;

        [Compare(nameof(Password), ErrorMessage = "Las claves no coinciden")]
        public string ConfirmPassword { get; set; } = default!;
    }
}
