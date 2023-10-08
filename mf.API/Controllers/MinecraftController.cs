using mf.domain.Commands;
using mf.domain.Handlers;
using mf.domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace mf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MinecraftController : ControllerBase
    {
        private readonly IMinecraftRepository _minecraftRepository;
        public MinecraftController(IMinecraftRepository minecraftRepository)
        {
            _minecraftRepository = minecraftRepository;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var models = await _minecraftRepository.getAll();
            return Ok(new CommandResult(models));
        }


        [HttpPost()]
        public async Task<IActionResult> CreateUserAsync([FromBody] CreateMinecraftCommand command, [FromServices] MinecraftHandler handler)
        {
            var handle = await handler.Handle(command);
            return Ok(handle);
        }
    }
}
