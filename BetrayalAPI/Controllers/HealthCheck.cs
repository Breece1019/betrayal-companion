using Microsoft.AspNetCore.Mvc;

namespace BetrayalAPI.Controllers
{
    [ApiController]
    [Route("betrayal/[controller]")]
    public class HealthCheck : ControllerBase
    {
        [HttpGet("health")]
        public IActionResult Heartbeat()
        {
            return Ok("beat");
        }
    }
}
