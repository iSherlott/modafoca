using mf.domain.Entities;
using mf.domain.Repositories;
using mf.infra.Data;
using Microsoft.AspNetCore.Mvc;

namespace mf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MinecraftController : ControllerBase
    {
        private readonly MinecraftRepository _minecraftRepository;
        public MinecraftController(MinecraftRepository minecraftRepository)
        {
            _minecraftRepository = minecraftRepository;
        }

        //private readonly ILogger _logger;

        //public MinecraftController(ILogger logger)
        //{
        //    _logger = logger;   
        //}

        [HttpPost()]
        public async Task<IActionResult> CreateUserAsync([FromBody] Minecraft minecraft)
        {
            //await _minecraftRepository.create(minecraft);
            return Ok(minecraft);
        }
    }
}
