using FesajoStudios.Entities;
using FesajoStudios.Repositories.Interfaces;
using FesajoStudios.Server.Extensions;
using FesajoStudios.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace FesajoStudios.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController: ControllerBase
    {
        private readonly ITicketRepository _repositoryTicket;
        private readonly IShowingRepository _repositoryShowing;
        private readonly ITicketTypeRepository _repositoryTypeTicket;
        private readonly IMovieRepository _repositoryMovie;
        public TicketsController(ITicketRepository repositoryTicket, IShowingRepository repositoryShowing, ITicketTypeRepository repositoryTicketType, IMovieRepository movieRepository )
        {
            _repositoryTicket = repositoryTicket;
            _repositoryTypeTicket = repositoryTicketType;
            _repositoryShowing = repositoryShowing;
            _repositoryMovie = movieRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repositoryTicket.ListAsync()); //Carga la lista inicializada
        }

        [HttpGet("GetTicketsByShowingId/{id:int}")]
        [ActionName("GetTicketsByShowingId")]
        public async Task<IActionResult> GetTicketsByShowingId(int id)
        {
            var tickets = await _repositoryTicket.ListAsync();
            var typeTickets = await _repositoryTypeTicket.ListAsync();
            var showings = await _repositoryShowing.ListAsync();
            var movies = await _repositoryMovie.ListAsync();

            var ticketDto = tickets.GetTicketsByShowingIdConvertToDto(typeTickets, showings, movies, id);
            if (ticketDto == null)
            {
                return NotFound();
            }
            return Ok(ticketDto);
        }

    }
}
