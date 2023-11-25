using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Shared.Reponse
{
    public class ClientResponseDto
    {
       
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string Email { get; set; } = default!;

        public DateTime Birthdate { get; set; }

        public int ClientTypeId { get; set; }
    }
}
