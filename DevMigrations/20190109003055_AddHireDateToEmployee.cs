using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvEFCoreMigrations.Migrations
{
    public partial class AddHireDateToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "moretasks",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "moretasks",
                table: "Employees",
                nullable: true);
        }
    }
}
