using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.DataAccess
{
    public class IdentityUserFesajoStudios : IdentityUser
    {
        public string FullName { get; set; } = default!;
        public DateTime BirthDate { get; set; }

        public string Address { get; set; } = default!;
    }
}
