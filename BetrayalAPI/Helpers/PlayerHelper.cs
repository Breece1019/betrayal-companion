using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BetrayalAPI.Models.Players;

namespace BetrayalAPI.Helpers;

public static class PlayerHelper
{
    // Cache to store player instances by name
    private static readonly Dictionary<string, IPlayer> PlayerCache = new(StringComparer.OrdinalIgnoreCase);

    public static IPlayer GetPlayer(string playerName)
    {
        var playerClassName = playerName.Replace(" ", "").Replace("\"", "");
        
        // Check if player already exists in cache
        if (PlayerCache.TryGetValue(playerClassName, out var existingPlayer))
        {
            return existingPlayer;
        }
        
        // If not, create a new instance
        var assembly = Assembly.GetExecutingAssembly();
        var type = assembly.GetTypes()
            .FirstOrDefault(t => typeof(IPlayer).IsAssignableFrom(t)
                && string.Equals(t.Name, playerClassName, StringComparison.OrdinalIgnoreCase));
        var newPlayer = (IPlayer)Activator.CreateInstance(type);

        // Add to cache
        PlayerCache[playerClassName] = newPlayer;
        
        return newPlayer;
    }
}
