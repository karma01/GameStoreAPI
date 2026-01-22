namespace GameStore.DTOs;

public record GameDetailsDto(
    int Id,
    string Name,
    decimal GenreId,
    decimal Price,
    DateOnly releaseDate
    
    );