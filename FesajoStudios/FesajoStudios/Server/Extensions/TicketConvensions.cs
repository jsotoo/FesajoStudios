using FesajoStudios.Entities;
using FesajoStudios.Shared;
using FesajoStudios.Shared.Reponse;

namespace FesajoStudios.Server.Extensions
{
    public static class TicketConvensions
    {
        public static IEnumerable<TicketDtoResponse> GetTicketsByShowingIdConvertToDto(this IEnumerable<Ticket> tickets,
                                                            IEnumerable<TicketType> ticketTypes,
                                                            IEnumerable<Showing> showings,IEnumerable<Movie> movies, int id)
        {
            return (from ticket in tickets
                    join ticketType in ticketTypes on ticket.TicketTypeId equals ticketType.Id
                    join showing in showings on ticket.ShowingId equals showing.Id
                    join movie in movies on showing.MovieId equals movie.Id
                    where ticket.ShowingId == id
                    select new TicketDtoResponse
                    {
                       Id = ticket.Id,
                       TicketTypeId = ticket.TicketTypeId,
                       TicketType = ticketType.Description,
                       Price = ticket.Price,
                       ShowingId = showing.Id,
                       Showing = movie.Title

                    }).ToList();

        }

    }
}
