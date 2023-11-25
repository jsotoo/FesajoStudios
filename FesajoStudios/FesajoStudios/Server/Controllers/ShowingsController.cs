using FesajoStudios.Entities;
using FesajoStudios.Repositories.Interfaces;
using FesajoStudios.Server.Extensions;
using FesajoStudios.Shared;
using FesajoStudios.Shared.Request;
using Microsoft.AspNetCore.Mvc;

namespace FesajoStudios.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShowingsController : ControllerBase
    {
        private readonly IShowingRepository _showingrepository;
        private readonly IMovieRepository _movierepository;
        private readonly ITheatherRepository _theatherRepository;

        public ShowingsController(IShowingRepository showingrepository, IMovieRepository movierepository, ITheatherRepository theatherRepository)
        {
            _showingrepository = showingrepository;
            _movierepository = movierepository;
            _theatherRepository = theatherRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string? filter)
        {
            var lista = await _showingrepository.ListAsync(
            predicate: p => p.State && p.Movie.Title.Contains(filter ?? string.Empty),
              selector: x => new ShowingDto
              {
                   Id = x.Id,
                   StartDate = x.StartDate,
                   EndDate = x.EndDate,
                   Movie = x.Movie.Title,
                   Theather = x.Theather.Name

              }, relations: "Movie,Theather");

            return Ok(lista);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _showingrepository.FindAsync(id));
        }


        
        [HttpGet("GetShowingsByMovieId/{id:int}")]
        [ActionName("GetShowingsByMovieId")]
        public async Task<IActionResult> GetShowingsByMovieId(int id)
        {
   
     
            var showings = await _showingrepository.ListAsync();
            var movies = await _movierepository.ListAsync();
            var theathers = await _theatherRepository.ListAsync();

            var showingDto = showings.ConvertToDtoGetShowingsByMovieId(movies, theathers, id);
            return Ok(showingDto);

        }




        [HttpPost]
        public async Task<IActionResult> Post(ShowingDtoRequest request)
        {
            var showing = new Showing()
            {
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                MovieId = request.MovieId,
                TheatherId = request.TheatherId
            };

            await _showingrepository.AddAsync(showing);

            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, ShowingDtoRequest request)
        {
            var field = await _showingrepository.FindAsync(id);

            if (field is null)
            {
                return NotFound();
            }

            field.StartDate = request.StartDate;
            field.EndDate = request.EndDate;
            field.MovieId = request.MovieId;
            field.TheatherId = request.MovieId;

            await _showingrepository.UpdateAsync();

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _showingrepository.DeleteAsync(id);
            return Ok();
        }





    }
}
