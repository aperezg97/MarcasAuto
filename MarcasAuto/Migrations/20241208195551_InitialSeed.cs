using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarcasAuto.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MarcasAuto",
                columns: new[] { "Id", "Make" },
                values: new object[,]
                {
                    { "8901d8dd-24b0-4f56-a523-6d6694b9a4ac", "Toyota" },
                    { "91de0725-5e4d-49af-b63d-1dfc6b7699c9", "Ford" },
                    { "ff5425c0-ed1d-422d-ad1d-47a1e5f8b8f1", "Chevrolet" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MarcasAuto",
                keyColumn: "Id",
                keyValue: "8901d8dd-24b0-4f56-a523-6d6694b9a4ac");

            migrationBuilder.DeleteData(
                table: "MarcasAuto",
                keyColumn: "Id",
                keyValue: "91de0725-5e4d-49af-b63d-1dfc6b7699c9");

            migrationBuilder.DeleteData(
                table: "MarcasAuto",
                keyColumn: "Id",
                keyValue: "ff5425c0-ed1d-422d-ad1d-47a1e5f8b8f1");
        }
    }
}
