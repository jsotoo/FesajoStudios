using FesajoStudios.Entities;
using FesajoStudios.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FesajoStudios.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TheathersController: ControllerBase
    {
        private readonly ITheatherRepository _repository;
        public TheathersController(ITheatherRepository repository)
        {
            _repository = repository;
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
        public async Task<IActionResult> Post(Theather request)
        {
            await _repository.AddAsync(request);

            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, Theather request)
        {
            var field = await _repository.FindAsync(id);

            if (field is null)
            {
                return NotFound();
            }

            field.Name = request.Name;
            field.Capacity = request.Capacity;

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
