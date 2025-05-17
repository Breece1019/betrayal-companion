using System;
using BetrayalAPI.Models.Players;

namespace BetrayalAPI.Helpers;

public static class TraitHelper
{
    public enum Traits
    {
        Speed,
        Might,
        Sanity,
        Knowledge
    };

    private static Trait GetTrait(IPlayer player, Traits trait)
    {
        Trait result = trait switch
        {
            Traits.Speed => player.Speed,
            Traits.Might => player.Might,
            Traits.Sanity => player.Sanity,
            Traits.Knowledge => player.Knowledge,
            _ => null
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
        if (trait is null || trait.Pointer >= trait.Values.Length - 1)
        {
            return null;
        }

        return ++trait.Pointer;
    }

    public static int? DecrementTraitValue(IPlayer player, Traits traitName)
    {
        Trait trait = GetTrait(player, traitName);
        if (trait is null || trait.Pointer <= 0)
        {
            return null;
        }

        return --trait.Pointer;
    }

    public static int? RollTrait(IPlayer player, Traits traitName)
    {
        Trait trait = GetTrait(player, traitName);

        return trait is null
            ? null
            : DiceHelper.RollDice(trait.CurrentValue);
    }
}