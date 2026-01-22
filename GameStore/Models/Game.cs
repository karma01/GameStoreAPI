namespace GameStore.Models;

public class Game
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int GenreID { get; set; }

    public decimal Price { get; set; }
    public Genre Genre { get; set; }
    public DateOnly releaseDate { get; set; }
}