using Microsoft.AspNetCore.Mvc;

namespace mf.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        //private readonly ILogger _logger;

        //public HomeController(ILogger logger)
        //{
        //    _logger = logger;   
        //}

        [HttpGet()]
        public async Task<IActionResult> isOnline()
        {
                return Ok(true);
        }
    }
}
