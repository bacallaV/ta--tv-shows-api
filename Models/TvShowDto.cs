using System.ComponentModel.DataAnnotations;

namespace TvShows.Dtos;

public class TvShowDto {
    [Required]
    public required string Name { get; set; }
    [Required]
    public required bool Favorite { get; set; }   
}