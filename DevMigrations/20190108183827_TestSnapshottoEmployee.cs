using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvEFCoreMigrations.Migrations
{
    public partial class TestSnapshottoEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn2<string>(
                name: "moretasks",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn2<string>(
                name: "tasks",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "moretasks",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "tasks",
                table: "Employees");
        }
    }
}
