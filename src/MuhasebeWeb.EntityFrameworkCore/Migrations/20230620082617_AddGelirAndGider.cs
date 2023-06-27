using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuhasebeWeb.Migrations
{
    public partial class AddGelirAndGider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gider",
                table: "Gider",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gelir",
                table: "Gelir",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gider",
                table: "Gider");

            migrationBuilder.DropColumn(
                name: "Gelir",
                table: "Gelir");
        }
    }
}
