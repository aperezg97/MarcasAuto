using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarcasAuto.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarcasAuto",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Make = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcasAuto", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MarcasAuto_Id",
                table: "MarcasAuto",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarcasAuto");
        }
    }
}
