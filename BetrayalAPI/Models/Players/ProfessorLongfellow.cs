namespace BetrayalAPI.Models.Players;

public class ProfessorLongfellow : IPlayer
{
    public string Name { get; set; } = "Professor Longfellow";
    public Trait Speed { get; set; } = new Trait
    {
        Values = [0, 2, 2, 4, 4, 5, 5, 6, 6],
        Pointer = 4
    };
    public Trait Might { get; set; } = new Trait
    {
        Values = [0, 1, 2, 3, 4, 5, 5, 6, 6],
        Pointer = 3
    };
    public Trait Sanity { get; set; } = new Trait
    {
        Values = [0, 1, 3, 3, 4, 5, 5, 6, 7],
        Pointer = 3
    };
    public Trait Knowledge { get; set; } = new Trait
    {
        Values = [0, 4, 5, 5, 5, 5, 6, 7, 8],
        Pointer = 5
    };
}