using BetrayalAPI.Constants;
using BetrayalAPI.Models.Players;
using BetrayalAPI.Models.Request;
using Microsoft.AspNetCore.Http.HttpResults;
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
            
            // Get Trait Value using reflection
            var traitProperty = typeof(IPlayer).GetProperty(traitRequest.Trait.ToString());
            var traitObject = traitProperty?.GetValue(player);
            var currentValueProperty = traitObject?.GetType().GetProperty(nameof(Trait.CurrentValue));
            var result = (int)(currentValueProperty?.GetValue(traitObject) ?? -1);

            return result != -1
                    ? Ok($"You want trait: {traitRequest.Trait} from player: {traitRequest.PlayerName}, which is: {result}")
                    : NotFound($"Unable to Locate trait: {traitRequest.Trait} for player: {traitRequest.PlayerName}");
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
