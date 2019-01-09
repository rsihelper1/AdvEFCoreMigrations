using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvEFCoreMigrations.Migrations
{
    public partial class AddHeightWeightToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn2<string>(
                name: "heighweight",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "heighweight",
                table: "Employees");
        }
    }
}
