namespace BetrayalAPI.Models.Players;

public class PeterAkimoto : IPlayer
{
    public string Name { get; set; } = "Peter Akimoto";
    public Trait Speed { get; set; } = new Trait
    {
        Values = [0, 3, 3, 3, 4, 6, 6, 7, 7],
        Pointer = 4
    };
    public Trait Might { get; set; } = new Trait
    {
        Values = [0, 2, 3, 3, 4, 5, 5, 6, 8],
        Pointer = 3
    };
    public Trait Sanity { get; set; } = new Trait
    {
        Values = [0, 3, 4, 4, 4, 5, 6, 6, 7],
        Pointer = 4
    };
    public Trait Knowledge { get; set; } = new Trait
    {
        Values = [0, 3, 4, 4, 5, 6, 7, 7, 8],
        Pointer = 3
    };
}