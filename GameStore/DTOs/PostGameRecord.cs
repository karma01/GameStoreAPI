using System.ComponentModel.DataAnnotations;

namespace GameStore.DTOs;

public record  PostGameRecord
(
  [Required] [StringLength(40)]string Name,
   [Required] [Range(1,50)]int  GenreId,
    [Range(1,200)] decimal Price,
    DateOnly releaseDate
);
