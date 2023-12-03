using Azure.Core;
using FesajoStudios.Entities;
using FesajoStudios.Repositories.Implementations;
using FesajoStudios.Repositories.Interfaces;
using FesajoStudios.Server.Extensions;
using FesajoStudios.Server.Services;
using FesajoStudios.Shared;
using FesajoStudios.Shared.Reponse;
using FesajoStudios.Shared.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace FesajoStudios.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeatsController: ControllerBase
    {
        private readonly ISeatRepository _repository;
        private readonly ISeatTypeRepository _repositorySeatType;
        private readonly IShowingRepository _repositoryShowing;
        private readonly IMovieRepository _repositoryMovie;
        private readonly ISeatXBookingRepository _repositorySeatXBooking;
        private readonly ITheatherRepository _repositoryTheather;

        public SeatsController(ISeatRepository repository, ISeatTypeRepository repositoryTpe, IShowingRepository repoShowing, IMovieRepository repoMovie, ISeatXBookingRepository repositorySeatXBooking, ITheatherRepository repositoryTheather)
        {
            _repository = repository;
            _repositorySeatType = repositoryTpe;
            _repositoryShowing = repoShowing;
            _repositoryMovie = repoMovie;
            _repositorySeatXBooking = repositorySeatXBooking;
            _repositoryTheather = repositoryTheather;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var seats = await _repository.ListAsync();
            var seatType = await _repositorySeatType.ListAsync();
            var theather = await _repositoryTheather.ListAsync();
            var showing = await _repositoryShowing.ListAsync();
            var movie = await _repositoryMovie.ListAsync();

            var seatDto = seats.GetConvertToDto(seatType, theather, showing, movie);
            return Ok(seatDto);

        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var seats = await _repository.ListAsync();
                var seatType = await _repositorySeatType.ListAsync();
                var theather = await _repositoryTheather.ListAsync();
                var showing = await _repositoryShowing.ListAsync();
                var movie = await _repositoryMovie.ListAsync();

                var seatDto = seats.GetByIdConvertToDto(seatType, theather, showing, movie, id);

                if (seatDto == null)
                {
                    return NotFound();
                }

                return Ok(seatDto);
            }
            catch (Exception ex)
            {
                // Loguear la excepción o devolver un resultado apropiado.
                return StatusCode(500, $"Error inesperado: {ex.Message}");
            }
        }


        [HttpGet("GetSeatsByShowingId/{id:int}")]
        [ActionName("GetSeatsByShowingId")]
        public async Task<IActionResult> GetSeatsByShowingId(int id)
        {
            try
            {
                var seats = await _repository.ListAsync();
                var seatType = await _repositorySeatType.ListAsync();
                var showing = await _repositoryShowing.ListAsync();
                var theather = await _repositoryTheather.ListAsync();
                var movie = await _repositoryMovie.ListAsync();

                var seatDto = seats.GetByShowingIdConvertToDto(seatType, theather, showing, movie, id);

                var totalDto = seatDto.Count();

                if (seatDto == null)
                {
                    return NotFound();
                }

                return Ok(seatDto);
            }
            catch (Exception ex)
            {
                // Loguear la excepción o devolver un resultado apropiado.
                return StatusCode(500, $"Error inesperado: {ex.Message}");
            }
        }

        [HttpGet("GetSeatsByBookingId/{id:int}")]
        [ActionName("GetSeatsByBookingId")]
        public async Task<IActionResult> GetSeatsByBookingId(int id)
        {
            try
            {
                var seats = await _repository.ListAsync();
                var seatXBooking = await _repositorySeatXBooking.ListAsync();
                var seatType = await _repositorySeatType.ListAsync();
                var showing = await _repositoryShowing.ListAsync();
                var movie = await _repositoryMovie.ListAsync();
                var theather = await _repositoryTheather.ListAsync();

                var seatDto = seats.GetByBookingIdConvertToDto(seatXBooking, seatType,theather, showing, movie, id);

                if (seatDto == null)
                {
                    return NotFound();
                }

                return Ok(seatDto);
            }
            catch (Exception ex)
            {
                // Loguear la excepción o devolver un resultado apropiado.
                return StatusCode(500, $"Error inesperado: {ex.Message}");
            }
        }


        [HttpPut("PutBySeatType/{id:int}")]
        [ActionName("PutBySeatType")]
        public async Task<IActionResult> PutBySeatType(int id, SeatDtoRequest request)
        {
            try
            {
                var registro = await _repository.FindAsync(id);

                if (registro is null)
                {
                    return NotFound();
                }

                // Actualiza propiedades que no son clave.
                registro.SeatTypeId = request.SeatTypeId;


                await _repository.UpdateAsyncEntity(registro);

                return Ok();
            }
            catch (Exception ex)
            {
                // Loggea la excepción o devuelve información detallada en la respuesta.
                return StatusCode(500, $"Error interno del servidor: {ex.Message} \n\nInner Exception: {ex.InnerException?.Message}");
            }
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, SeatDtoRequest request)
        {
            try
            {
                var registro = await _repository.FindAsync(id);

                if (registro is null)
                {
                    return NotFound();
                }

                // Actualiza propiedades que no son clave.
                registro.SeatTypeId = request.SeatTypeId;
                //registro.ShowingId = request.ShowingId;
                registro.SeatCode = request.SeatCode;

                await _repository.UpdateAsyncEntity(registro);

                return Ok();
            }
            catch (Exception ex)
            {
                // Loggea la excepción o devuelve información detallada en la respuesta.
                return StatusCode(500, $"Error interno del servidor: {ex.Message} \n\nInner Exception: {ex.InnerException?.Message}");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Post(SeatDtoRequest request)
        {
            var seat = new Seat()
            {
                SeatCode = request.SeatCode,
                SeatTypeId = request.SeatTypeId,
                ShowingId = request.ShowingId,
                TheatherId = request.TheatherId,

            };

            await _repository.AddAsync(seat);

            return Ok();
        }







    }
}
