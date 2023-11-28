using FesajoStudios.Entities;
using FesajoStudios.Repositories.Interfaces;
using FesajoStudios.Server.Extensions;
using FesajoStudios.Shared.Request;
using Microsoft.AspNetCore.Mvc;

namespace FesajoStudios.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingsController: ControllerBase
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IShowingRepository _showingRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IBookingTypeRepository _bookingTypeRepository;


        public BookingsController(IBookingRepository bookingRepository, IClientRepository clientRepository, IShowingRepository showingRepository, IMovieRepository movieRepository, IBookingTypeRepository bookingTypeRepository)
        {
            _bookingRepository = bookingRepository;
            _clientRepository = clientRepository;
            _showingRepository = showingRepository;
            _movieRepository = movieRepository;
            _bookingTypeRepository = bookingTypeRepository;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _bookingRepository.ListAsync()); //Carga la lista inicializada
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var bookings = await _bookingRepository.ListAsync();
            var clients = await _clientRepository.ListAsync();
            var showings = await _showingRepository.ListAsync();
            var movies = await _movieRepository.ListAsync();
            var bookingsType = await _bookingTypeRepository.ListAsync();

            var bookingDto = bookings.GetByBookingIdConvertToDto(bookingsType, clients, showings, movies, id);
            return Ok(bookingDto);

          
        }

        [HttpGet("GetByClientId/{id:int}")]
        [ActionName("GetByClientId")]
        public async Task<IActionResult> GetByClientId(int id)
        {
            var bookings = await _bookingRepository.ListAsync();
            var clients = await _clientRepository.ListAsync();
            var showings = await _showingRepository.ListAsync();
            var movies = await _movieRepository.ListAsync();
            var bookingsType = await _bookingTypeRepository.ListAsync();


            var bookingDto = bookings.GetByIdConvertToDto(bookingsType,clients,showings,movies,id);
            return Ok(bookingDto);

           
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

            await _bookingRepository.AddAsync(booking);

            // Devuelve el ID del nuevo booking en la respuesta.
            return Ok(new { Id = booking.Id });
        }

    }
}
