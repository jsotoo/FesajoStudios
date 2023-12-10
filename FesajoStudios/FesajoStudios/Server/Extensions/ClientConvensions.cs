using FesajoStudios.Entities;
using FesajoStudios.Shared;
using FesajoStudios.Shared.Reponse;

namespace FesajoStudios.Server.Extensions
{
    public static class ClientConvensions
    {
        public static ClientResponseDto? GetEmailByIdToDto(this IEnumerable<Entities.Client> clients, string email)
        {
            return clients.FirstOrDefault(client =>
                string.Equals(client.Email, email, StringComparison.OrdinalIgnoreCase)
            )?.ToClientResponseDto();
        }

        public static ClientResponseDto? ToClientResponseDto(this Entities.Client client)
        {
            if (client == null)
            {
                return null; 
            }

            return new ClientResponseDto
            {
                Id = client.Id,
                Birthdate = client.Birthdate,
                Email = client.Email,
                FirstName = client.FirstName,
                LastName = client.LastName,
                ClientTypeId = client.ClientTypeId
            };
        }


    }
}
