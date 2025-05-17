using System;

namespace BetrayalAPI.Helpers;

public static class DiceHelper
{
    private static readonly int maxDieValue = 2;
    private static readonly int maxDiceCount = 8;
    private static readonly Random rnd = new();

    public static int RollDice(int numDice)
    {
        var maxValue = (maxDieValue * numDice) + 1;
        return rnd.Next(maxValue);
    }

    public static int HauntRoll()
    {
        return RollDice(maxDiceCount);
    }
}
