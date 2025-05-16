using System;
using BetrayalAPI.Constants;
using BetrayalAPI.Models.Players;

namespace BetrayalAPI.Helpers;

public static class TraitHelper
{
    public static int GetTraitValue(IPlayer player, Traits trait)
    {
        var traitProperty = player.GetType().GetProperty(trait.ToString());
        var traitObject = (Trait)traitProperty?.GetValue(player);

        return traitObject.CurrentValue;
    }

    public static void IncrementTraitValue(IPlayer player, Traits trait)
    {
        var traitProperty = player.GetType().GetProperty(trait.ToString());
        var traitObject = (Trait)traitProperty?.GetValue(player);

        traitObject.Pointer++;
    }
}