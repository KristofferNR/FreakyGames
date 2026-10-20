namespace FreakyGames.Models;

public class Genre
{
    public int Id { get; set; }
    public required string GenreName { get; set; }
    public List<Game> Games { get; set; } = [];
}
