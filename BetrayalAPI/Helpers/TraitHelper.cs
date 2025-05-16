using BetrayalAPI.Constants;
using BetrayalAPI.Models.Players;

namespace BetrayalAPI.Helpers;

public static class TraitHelper
{
    private static Trait GetTrait(IPlayer player, Traits trait)
    {
        var traitProperty = player.GetType().GetProperty(trait.ToString());
        return (Trait)traitProperty?.GetValue(player);
    }
    
    public static int GetTraitValue(IPlayer player, Traits trait)
    {
        return GetTrait(player, trait).CurrentValue;
    }

    public static int IncrementTraitValue(IPlayer player, Traits trait)
    {
        return ++GetTrait(player, trait).Pointer;
    }
}