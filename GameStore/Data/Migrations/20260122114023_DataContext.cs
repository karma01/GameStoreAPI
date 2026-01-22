using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class DataContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_game_genre_GenreId",
                table: "game");

            migrationBuilder.DropIndex(
                name: "IX_game_GenreId",
                table: "game");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "game",
                newName: "GenreID");

            migrationBuilder.AlterColumn<int>(
                name: "GenreID",
                table: "game",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "game",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "game");

            migrationBuilder.RenameColumn(
                name: "GenreID",
                table: "game",
                newName: "GenreId");

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "game",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_game_GenreId",
                table: "game",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_game_genre_GenreId",
                table: "game",
                column: "GenreId",
                principalTable: "genre",
                principalColumn: "Id");
        }
    }
}
