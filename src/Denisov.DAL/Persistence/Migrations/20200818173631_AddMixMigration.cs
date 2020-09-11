using Microsoft.EntityFrameworkCore.Migrations;

namespace Denisov.DAL.Migrations
{
    public partial class AddMixMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Mixes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Flavour",
                table: "Mixes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Mixes");

            migrationBuilder.DropColumn(
                name: "Flavour",
                table: "Mixes");
        }
    }
}
