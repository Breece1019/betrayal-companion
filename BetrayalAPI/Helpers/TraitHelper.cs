using System;
using BetrayalAPI.Constants;
using BetrayalAPI.Models.Players;

namespace BetrayalAPI.Helpers;

public static class TraitHelper
{
    private static Trait GetTrait(IPlayer player, Traits trait)
    {
        Trait result = trait switch
        {
            Traits.Speed => player.Speed,
            Traits.Might => player.Might,
            Traits.Sanity => player.Sanity,
            Traits.Knowledge => player.Knowledge,
            _ => throw new ArgumentException($"Unknown trait: {trait}", nameof(trait)),
        };
        return result;
    }

    public static int GetTraitValue(IPlayer player, Traits traitName)
    {
        return GetTrait(player, traitName).CurrentValue;
    }

    public static int? IncrementTraitValue(IPlayer player, Traits traitName)
    {
        Trait trait = GetTrait(player, traitName);
        if (trait.Pointer >= trait.Values.Length)
        {
            return null;
        }
        
        return ++trait.Pointer;
    }
    
    public static int? DecrementTraitValue(IPlayer player, Traits traitName)
    {
        Trait trait = GetTrait(player, traitName);
        if (trait.Pointer >= trait.Values.Length)
        {
            return null;
        }
        
        return --trait.Pointer;
    }
}