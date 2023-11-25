using FesajoStudios.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FesajoStudios.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeatsTypeController: ControllerBase
    {
        private readonly ISeatTypeRepository _repository;
        public SeatsTypeController(ISeatTypeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repository.ListAsync());
        }

    }
}
