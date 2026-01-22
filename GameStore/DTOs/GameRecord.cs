namespace GameStore.DTOs;

public record GameRecord(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate
);