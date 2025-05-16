using BetrayalAPI.Models.Players;
using Microsoft.AspNetCore.Mvc;

namespace BetrayalAPI.Controllers
{
    [ApiController]
    [Route("betrayal/[controller]")]
    public class PlayerController : ControllerBase
    {
        [HttpGet("traits/{trait}")]
        public IActionResult GetTraitValue(int trait)
        {
            return Ok(new { Message = $"TODO: You want trait number: {trait}" });
        }

        // GET api/player
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Hello, world!" });
        }

        // GET api/player/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            IPlayer player = new ProfessorLongfellow();
            player.Might.Pointer = 3;

            return Ok(new { Message = $"You requested item {id}" });
        }
    }
}
