using FesajoStudios.Entities;
using FesajoStudios.Repositories.Implementations;
using FesajoStudios.Repositories.Interfaces;
using FesajoStudios.Server.Extensions;
using FesajoStudios.Server.Services;
using FesajoStudios.Shared;
using FesajoStudios.Shared.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FesajoStudios.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController: ControllerBase
    {
        private readonly IMovieRepository _repository;
        private readonly IFileUploader _fileUploader;
        private readonly IShowingRepository _showingRepository;
        public MoviesController(IMovieRepository repository, IFileUploader fileUploader, IShowingRepository showingRepository)
        {
            _repository = repository;
            _fileUploader = fileUploader;
            _showingRepository = showingRepository;
        }


        [HttpGet]
        public async Task<IActionResult> Get(string? filter)
        {
            var lista = await _repository.ListAsync(
            predicate: p => p.State && p.Title.Contains(filter ?? string.Empty),
              selector: x => new MovieDto
              {
                  Id = x.Id,
                  Title = x.Title,
                  Description = x.Description,
                  Director = x.Director,
                  Duration = x.Duration,
                  Genre = x.Genre,
                  Rating = x.Rating,
                  ReleaseDate = x.ReleaseDate,
                  UrlImage = x.UrlImage


              }, relations: "");

            return Ok(lista);
        }





        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _repository.FindAsync(id));
        }

        [HttpGet("GetMoviesByShowingId/{id:int}")]
        [ActionName("GetMoviesByShowingId")]
        public async Task<IActionResult> GetMoviesByShowingId(int id)
        {
            var movies = await _repository.ListAsync();
            var showings = await _showingRepository.ListAsync();

            var movieDto = movies.GetMoviesByShowingIdConvertToDto(showings, id);

            return Ok(movieDto);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Post(MovieDto request)
        {

            request.UrlImage = await _fileUploader.UploadFileAsync(request.Base64Image, request.NameFile);

            var movie = new Movie()
            {
                Id = request.Id,
                Title = request.Title,
                Description = request.Description,
                Duration = request.Duration,
                Rating = request.Rating,
                Director = request.Director,
                Genre = request.Genre,
                ReleaseDate = request.ReleaseDate,
                UrlImage = request.UrlImage
            };

           

            await _repository.AddAsync(movie);

            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, MovieDto request)
        {
            var field = await _repository.FindAsync(id);

            if (field is null)
            {
                return NotFound();
            }

            if (!string.IsNullOrWhiteSpace(request.Base64Image))
            {
                request.UrlImage = await _fileUploader.UploadFileAsync(request.Base64Image, request.NameFile);
            }

            field.Title = request.Title;
            field.Description = request.Description;
            field.Duration = request.Duration;
            field.Rating = request.Rating;
            field.Director = request.Director;
            field.Genre = request.Genre;
            field.ReleaseDate = request.ReleaseDate;
            field.UrlImage = request.UrlImage;


            await _repository.UpdateAsync();

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return Ok();
        }

    }
}
