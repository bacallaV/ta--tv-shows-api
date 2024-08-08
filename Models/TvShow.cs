namespace TvShows.Models;

public class TvShow
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required bool Favorite { get; set; }
}
