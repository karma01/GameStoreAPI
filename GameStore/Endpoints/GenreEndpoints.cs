using GameStore.Data;
using GameStore.DTOs;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Endpoints;

public static class GenreEndpoints
{
    public static void MapGenreEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/genre");

        group.MapGet("/",
            async (GameStoreContext storeContext) =>
            {
                return await storeContext.genre.Select(genre => new GenreDto(genre.Id, genre.Name)).AsNoTracking()
                    .ToListAsync();
            });
        
    }
}