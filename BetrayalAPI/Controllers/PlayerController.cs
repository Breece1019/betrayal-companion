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
                    ? Ok(result)
                    : NotFound($"Unable to Locate trait: {traitRequest.Trait} for player: {traitRequest.PlayerName}");
        }

        [HttpPost("traits/increment")]
        public IActionResult IncrementTraitValue([FromBody] TraitRequestModel traitRequest)
        {
            var player = PlayerHelper.GetPlayer(traitRequest.PlayerName);
            var pointer = TraitHelper.IncrementTraitValue(player, traitRequest.Trait);

            return pointer != null
                    ? Ok(pointer)
                    : BadRequest("Pointer cannot increment further");
        }

        [HttpPost("traits/decrement")]
        public IActionResult DecrementTraitValue([FromBody] TraitRequestModel traitRequest)
        {
            var player = PlayerHelper.GetPlayer(traitRequest.PlayerName);
            var pointer = TraitHelper.DecrementTraitValue(player, traitRequest.Trait);

            return pointer != null
                    ? Ok(pointer)
                    : BadRequest("Pointer cannot increment further");
        }

        [HttpGet("traits/roll")]
        public IActionResult RollTrait([FromQuery] TraitRequestModel traitRequest)
        {
            var player = PlayerHelper.GetPlayer(traitRequest.PlayerName);
            var result = TraitHelper.RollTrait(player, traitRequest.Trait);

            return result != null
                    ? Ok(result)
                    : BadRequest($"The Trait: {traitRequest.Trait} was not found and cannot be rolled");
        }
    }
}
