using FesajoStudios.Shared.Reponse;
using FesajoStudios.Shared.Request;
using System.Threading.Tasks;

namespace FesajoStudios.Client.Proxy.Interfaces
{
    public interface IUserProxy
    {
        Task<LoginDtoResponse> Login(LoginDtoRequest request);

        Task Register(RegisterUserDto request);
    }
}
