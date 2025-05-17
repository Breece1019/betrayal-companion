using static BetrayalAPI.Helpers.TraitHelper;

namespace BetrayalAPI.Models.Request;

public class TraitRequestModel
{
    public string PlayerName { get; set; }
    public Traits Trait { get; set; }
}