using FesajoStudios.Entities;
using FesajoStudios.Repositories.Interfaces;
using FesajoStudios.Shared.Request;
using Microsoft.AspNetCore.Mvc;

namespace FesajoStudios.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeatsXBookingsController: ControllerBase
    {
        private readonly ISeatXBookingRepository _seatBookingRepository;

        public SeatsXBookingsController(ISeatXBookingRepository seatBookingRepository)
        {
            _seatBookingRepository = seatBookingRepository;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _seatBookingRepository.ListAsync()); //Carga la lista inicializada
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _seatBookingRepository.FindAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(SeatXBookingDtoRequest request)
        {

            var booking = new SeatXBooking()
            {
                Id = request.Id,
                BookingId = request.BookingId,
                SeatId  = request.SeatId
            };


            await _seatBookingRepository.AddAsync(booking);

            return Ok();
        }
    }
}

