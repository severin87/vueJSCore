using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.Migrations
{
    public partial class InitialTRef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPlayer",
                table: "Moves",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPlayer",
                table: "Moves");
        }
    }
}
