namespace FreakyGames.Models;

public class Game
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string Genre { get; set; }
    public required int price { get; set; }

    public int GenreId { get; set; }

}
