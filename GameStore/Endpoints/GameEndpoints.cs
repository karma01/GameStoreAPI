using GameStore.Data;
using GameStore.DTOs;
using GameStore.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Endpoints;

public static class GameEndpoints
{
    public static void MapEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/games");
        group.MapGet("/", async (GameStoreContext storeContext) =>
        {
            return await storeContext.game.Include(game => game.Genre)
                .Select(game => new GameRecord(
                    game.Id,
                    game.Name,
                    game.Genre.Name,
                    game.Price,
                    game.releaseDate
                )).AsNoTracking().ToListAsync();
        });

        const string gameEndpointName = "GetGame";

        group.MapGet("/{id}", async (int id, GameStoreContext storeContext) =>
        {
            var game = await storeContext.game.FindAsync(id);

            if (game is null)
                return Results.NotFound();

            GameDetailsDto gameDetail = new(game.Id, game.Name, game.GenreID, game.Price, game.releaseDate);
            return Results.Ok(gameDetail);
        }).WithName(gameEndpointName);


        group.MapPost("/", async (PostGameRecord gameRecord, GameStoreContext storeContext) =>
        {
            if (String.IsNullOrEmpty(gameRecord.Name))
            {
                return Results.BadRequest("Name is compulsary");
            }

            Game game = new()
            {
                Name = gameRecord.Name,
                GenreID = gameRecord.GenreId,
                Price = gameRecord.Price,
                releaseDate = gameRecord.releaseDate,
            };

            storeContext.game.Add(game);
            await storeContext.SaveChangesAsync();

            GameDetailsDto record = new(game.Id, game.Name,
                game.Id,
                game.Price,
                game.releaseDate);

            return Results.CreatedAtRoute(gameEndpointName, new { id = record.Id }
                , record);
        });

        group.MapPut("/{id}", async (int id, UpdateGameDto updateGame, GameStoreContext storeContext) =>
        {
            var game = await storeContext.game.FindAsync(id);
            if (game is null)
            {
                return Results.NotFound();
            }

            game.Name = updateGame.Name;
            game.GenreID = updateGame.GenreId;
            game.Price = updateGame.Price;
            game.releaseDate = updateGame.releaseDate;

            await storeContext.SaveChangesAsync();

            return Results.NoContent();
        });

        group.MapDelete("/{id}", async (int id, GameStoreContext gameStoreContext) =>
        {
            await gameStoreContext.game.Where(game => game.Id == id).ExecuteDeleteAsync();

            return Results.NoContent();
        });
    }
}