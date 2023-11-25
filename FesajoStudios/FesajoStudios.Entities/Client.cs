using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Entities
{
    public class Client : EntityBase
    {
        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string Email { get; set; } = default!;

        public DateTime Birthdate { get; set; }

        public ClientType ClientType { get; set; } = default!;

        public int ClientTypeId { get; set; }
    }
}
