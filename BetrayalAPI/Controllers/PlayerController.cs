using BetrayalAPI.Helpers;
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
            var player = PlayerHelper.GetPlayer(traitRequest.PlayerName);

            var result = TraitHelper.GetTraitValue(player, traitRequest.Trait);

            return result != -1
                    ? Ok($"You want trait: {traitRequest.Trait} from player: {player.Name}, which is: {result}")
                    : NotFound($"Unable to Locate trait: {traitRequest.Trait} for player: {traitRequest.PlayerName}");
        }

        [HttpPost("traits")]
        public IActionResult IncrementTraitValue([FromBody] TraitRequestModel traitRequest)
        {
            var player = PlayerHelper.GetPlayer(traitRequest.PlayerName);

            TraitHelper.IncrementTraitValue(player, traitRequest.Trait);

            return NoContent();
        }
    }
}
