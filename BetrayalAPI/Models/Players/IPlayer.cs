
namespace BetrayalAPI.Models;

public interface IPlayer {
    public string Name { get; set; }
    public int[] Speed { get; set; }
    public int[] Might { get; set; }
    public int[] Sanity { get; set; }
    public int[] Knowledge { get; set; }
}