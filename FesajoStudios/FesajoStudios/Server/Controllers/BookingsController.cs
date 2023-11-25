using FesajoStudios.Entities;
using FesajoStudios.Repositories.Interfaces;
using FesajoStudios.Shared.Request;
using Microsoft.AspNetCore.Mvc;

namespace FesajoStudios.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingsController: ControllerBase
    {
        private readonly IBookingRepository _ticketRepository;

        public BookingsController(IBookingRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _ticketRepository.ListAsync()); //Carga la lista inicializada
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _ticketRepository.FindAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(BookingDtoRequest request)
        {

            var booking = new Booking()
            {
                Id = request.Id,
                ClientId = request.ClientId,
                BookingTypeId = request.BookingTypeId,
                ReservationDate = request.ReservationDate,
                ShowingId = request.ShowingId
            };


            await _ticketRepository.AddAsync(booking);

            return Ok();
        }
    }
}
