namespace BetrayalAPI.Models.Players;

public class FatherRhinehardt : IPlayer
{
    public string Name { get; set; } = "Father Rhinehardt";
    public Trait Speed { get; set; } = new Trait
    {
        Values = [0, 2, 3, 3, 4, 5, 6, 7, 7],
        Pointer = 3
    };
    public Trait Might { get; set; } = new Trait
    {
        Values = [0, 1, 2, 2, 4, 4, 5, 5, 7],
        Pointer = 3
    };
    public Trait Sanity { get; set; } = new Trait
    {
        Values = [0, 3, 4, 5, 5, 6, 7, 7, 8],
        Pointer = 5
    };
    public Trait Knowledge { get; set; } = new Trait
    {
        Values = [0, 1, 3, 3, 4, 5, 6, 6, 8],
        Pointer = 4
    };
}