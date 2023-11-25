using FesajoStudios.Entities;
using FesajoStudios.Repositories.Interfaces;
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
        public MoviesController(IMovieRepository repository, IFileUploader fileUploader)
        {
            _repository = repository;
            _fileUploader = fileUploader;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repository.ListAsync()); //Carga la lista inicializada
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _repository.FindAsync(id));
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
