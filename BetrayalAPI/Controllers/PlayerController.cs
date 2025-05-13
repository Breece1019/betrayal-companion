using Microsoft.AspNetCore.Mvc;

namespace BetrayalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : ControllerBase
    {
        // GET api/custom
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Hello, world!" });
        }

        // GET api/custom/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new { Message = $"You requested item {id}" });
        }
    }
}
