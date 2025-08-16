using System;

namespace BetrayalAPI.Helpers;

public static class DiceHelper
{
    private static readonly int maxDieValue = 2;
    private static readonly int maxDiceCount = 8;
    private static readonly Random rnd = new();

    public static int RollDice(int numDice)
    {
        var sum = 0;
        for (var i = 0; i < numDice; i++)
        {
            sum += rnd.Next(maxDieValue + 1);
        }

        return sum;
    }

    public static int HauntRoll()
    {
        return RollDice(maxDiceCount);
    }
}
