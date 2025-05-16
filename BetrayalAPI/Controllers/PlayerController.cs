using BetrayalAPI.Constants;
using BetrayalAPI.Models.Players;
using BetrayalAPI.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace BetrayalAPI.Controllers
{
    [ApiController]
    [Route("betrayal/[controller]")]
    public class PlayerController : ControllerBase
    {
        [HttpGet("traits")]
        public IActionResult GetTraitValue([FromQuery] TraitRequestModel traitRequest)
        {
            IPlayer player = new ProfessorLongfellow();
            int result = -1;

            switch (traitRequest.Trait)
            {
                case Traits.Speed:
                    result = player.Speed.CurrentValue;
                    break;
                case Traits.Might:
                    result = player.Might.CurrentValue;
                    break;
                case Traits.Sanity:
                    result = player.Sanity.CurrentValue;
                    break;
                case Traits.Knowledge:
                    result = player.Knowledge.CurrentValue;
                    break;
                default:
                    break;
            }

            return Ok(new { Message = $"TODO: You want trait: {traitRequest.Trait} from player: {traitRequest.PlayerName}, which is: {result}" });
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
