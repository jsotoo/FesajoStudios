using FesajoStudios.Entities;
using FesajoStudios.Repositories.Interfaces;
using FesajoStudios.Server.Extensions;
using FesajoStudios.Server.Services;
using FesajoStudios.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public SeatsController(ISeatRepository repository, ISeatTypeRepository repositoryTpe, IShowingRepository repoShowing, IMovieRepository repoMovie)
        {
            _repository = repository;
            _repositorySeatType = repositoryTpe;
            _repositoryShowing = repoShowing;
            _repositoryMovie = repoMovie;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            
           var seats = await _repository.ListAsync();
           var seatType = await _repositorySeatType.ListAsync();
           var showing = await _repositoryShowing.ListAsync();
           var movie = await _repositoryMovie.ListAsync();

            var seatDto = seats.GetConvertToDto(seatType,showing, movie);
            return Ok(seatDto);

        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var seats = await _repository.ListAsync();
                var seatType = await _repositorySeatType.ListAsync();
                var showing = await _repositoryShowing.ListAsync();
                var movie = await _repositoryMovie.ListAsync();

                var seatDto = seats.GetByIdConvertToDto(seatType, showing, movie, id);

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
                var movie = await _repositoryMovie.ListAsync();

                var seatDto = seats.GetByShowingIdConvertToDto(seatType, showing, movie, id);

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



    }
}
