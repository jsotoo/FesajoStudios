using FesajoStudios.Shared.Reponse;
using FesajoStudios.Shared.Request;

namespace FesajoStudios.Server.Services
{
    public interface IUserService
    {
        Task<LoginDtoResponse> LoginAsync(LoginDtoRequest request);
        Task<BaseResponse> RegisterAsync(RegisterUserDto request);
    }
}
