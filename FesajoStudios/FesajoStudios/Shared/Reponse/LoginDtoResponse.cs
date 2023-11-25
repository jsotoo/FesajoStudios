using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Shared.Reponse
{
    public class LoginDtoResponse : BaseResponse
    {
        public string Token { get; set; } = default!;
        public string FullName { get; set; } = default!;
        public ICollection<string> Roles { get; set; } = default!;
    }
}
