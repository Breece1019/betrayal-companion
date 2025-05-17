using BetrayalAPI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace BetrayalAPI.Controllers
{
    [ApiController]
    [Route("betrayal/[controller]")]
    public class HauntController : ControllerBase
    {
        [HttpGet("roll")]
        public IActionResult HauntRoll()
        {
            var result = DiceHelper.HauntRoll();

            return Ok(result);
        }
    }
}
