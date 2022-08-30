using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Workshop.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MainCharacters",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Mario" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "EmployeeCount", "Name" },
                values: new object[] { 1, 6500, "Nintendo" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Platformer" });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "MainCharacterId", "StudioId", "Title" },
                values: new object[] { 1, 1, 1, "Super Mario Brothers" });

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "TagId", "VideoGameId" },
                values: new object[] { 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MainCharacters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
