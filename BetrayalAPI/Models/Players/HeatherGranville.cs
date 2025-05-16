namespace BetrayalAPI.Models.Players;

public class HeatherGranville : IPlayer
{
    public string Name { get; set; } = "Heather Granville";
    public Trait Speed { get; set; } = new Trait
    {
        Values = [0, 3, 3, 4, 5, 6, 6, 7, 8],
        Pointer = 3
    };
    public Trait Might { get; set; } = new Trait
    {
        Values = [0, 3, 3, 3, 4, 5, 6, 7, 8],
        Pointer = 3
    };
    public Trait Sanity { get; set; } = new Trait
    {
        Values = [0, 3, 3, 3, 4, 5, 6, 6, 6],
        Pointer = 3
    };
    public Trait Knowledge { get; set; } = new Trait
    {
        Values = [0, 2, 3, 3, 4, 5, 6, 7, 8],
        Pointer = 5
    };
}