using Microsoft.EntityFrameworkCore.Migrations;

namespace RPGWizard1.Migrations
{
    public partial class Name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Races",
                table: "Race",
                newName: "Traits");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Race",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Race");

            migrationBuilder.RenameColumn(
                name: "Traits",
                table: "Race",
                newName: "Races");
        }
    }
}
