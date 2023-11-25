using FesajoStudios.Repositories.Interfaces;
using FesajoStudios.Server.Extensions;
using FesajoStudios.Server.Services;
using FesajoStudios.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FesajoStudios.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientRepository _repository;
        public ClientsController(IClientRepository repository)
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


        [HttpGet("byemail")]
        public async Task<IActionResult> GetClientByEmail([FromQuery] string email)
        {
            var clients = await _repository.ListAsync();
            var clientDto = clients.GetEmailByIdToDto(email);

            if (clientDto != null)
            {
                return Ok(clientDto);
            }
            else
            {
                return NotFound(); // Otra respuesta según tus necesidades si el cliente no se encuentra.
            }
        }





    }
}
