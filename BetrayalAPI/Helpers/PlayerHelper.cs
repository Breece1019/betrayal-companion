using System;
using System.Linq;
using System.Reflection;
using BetrayalAPI.Models.Players;

namespace BetrayalAPI.Helpers;

public static class PlayerHelper
{
    public static IPlayer GetPlayer(string playerName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var type = assembly.GetTypes()
            .FirstOrDefault(t => typeof(IPlayer).IsAssignableFrom(t)
                && string.Equals(t.Name, playerName.Replace(" ", "").Replace("\"", ""), StringComparison.OrdinalIgnoreCase));
        return (IPlayer)Activator.CreateInstance(type);
    }
}
