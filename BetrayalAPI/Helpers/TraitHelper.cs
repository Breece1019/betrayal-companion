using BetrayalAPI.Constants;
using BetrayalAPI.Models.Players;

namespace BetrayalAPI.Helpers;

public static class TraitHelper
{
    public static int GetTraitValue(IPlayer player, Traits trait)
    {
        // Get Trait Value using reflection
        var traitProperty = typeof(IPlayer).GetProperty(trait.ToString());
        var traitObject = traitProperty?.GetValue(player);
        var currentValueProperty = traitObject?.GetType().GetProperty(nameof(Trait.CurrentValue));

        return (int)(currentValueProperty?.GetValue(traitObject) ?? -1);
    }
}