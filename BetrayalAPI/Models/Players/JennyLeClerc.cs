namespace BetrayalAPI.Models.Players;

public class JennyLeClerc : IPlayer
{
    public string Name { get; set; } = "Jenny LeClerc";
    public Trait Speed { get; set; } = new Trait
    {
        Values = [0, 2, 3, 4, 4, 4, 5, 6, 8],
        Pointer = 4
    };
    public Trait Might { get; set; } = new Trait
    {
        Values = [0, 3, 4, 4, 4, 4, 5, 6, 8],
        Pointer = 3
    };
    public Trait Sanity { get; set; } = new Trait
    {
        Values = [0, 1, 1, 2, 4, 4, 4, 5, 6],
        Pointer = 5
    };
    public Trait Knowledge { get; set; } = new Trait
    {
        Values = [0, 2, 3, 3, 4, 4, 5, 6, 8],
        Pointer = 3
    };
}