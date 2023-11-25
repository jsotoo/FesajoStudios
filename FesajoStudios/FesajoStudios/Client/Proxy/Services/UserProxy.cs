using FesajoStudios.Client.Proxy.Interfaces;
using FesajoStudios.Shared.Reponse;
using FesajoStudios.Shared.Request;
using System.Net.Http.Json;

namespace FesajoStudios.Client.Proxy.Services
{
    public class UserProxy : IUserProxy
    {
        private readonly HttpClient _httpClient;

        public UserProxy(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LoginDtoResponse> Login(LoginDtoRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Users/Login", request);
            var loginResponse = await response.Content.ReadFromJsonAsync<LoginDtoResponse>();

            return loginResponse!;
        }

        public async Task Register(RegisterUserDto request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Users/Register", request);

            //response.EnsureSuccessStatusCode(); // Solo en caso de que no sepa el error en el backend

            if (response.IsSuccessStatusCode)
            {
                var resultado = await response.Content.ReadFromJsonAsync<BaseResponse>();
                if (resultado!.Success == false)
                    throw new InvalidOperationException(resultado.ErrorMessage);
            }
            else
                throw new InvalidOperationException(response.ReasonPhrase);
        }
    }
}
