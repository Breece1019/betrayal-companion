
namespace BetrayalAPI.Models.Players;

public interface IPlayer {
    public string Name { get; set; }
    public Trait Speed { get; set; }
    public Trait Might { get; set; }
    public Trait Sanity { get; set; }
    public Trait Knowledge { get; set; }
}

public class Trait
{
    public int[] Values { get; set; }
    public int Pointer { get; set; }

    public int CurrentValue => Values[Pointer];
}