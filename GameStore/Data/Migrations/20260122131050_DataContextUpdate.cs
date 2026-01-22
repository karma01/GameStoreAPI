using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class DataContextUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_game_GenreID",
                table: "game",
                column: "GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_game_genre_GenreID",
                table: "game",
                column: "GenreID",
                principalTable: "genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_game_genre_GenreID",
                table: "game");

            migrationBuilder.DropIndex(
                name: "IX_game_GenreID",
                table: "game");
        }
    }
}
