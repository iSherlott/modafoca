using Microsoft.AspNetCore.Mvc;

namespace mf.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpGet()]
        public IActionResult isOnline()
        {
            return Ok(true);
        }
    }
}
