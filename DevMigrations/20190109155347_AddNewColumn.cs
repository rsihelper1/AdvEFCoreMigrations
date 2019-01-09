using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvEFCoreMigrations.Migrations
{
    public partial class AddNewColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.KeepAliveCustomMigration(migrationBuilder.GetMigrationId(typeof(AddNewColumn)));
            migrationBuilder.AddColumn2<string>(
                name: "NewFieldForScriptGeneration",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewFieldForScriptGeneration",
                table: "Employees");
        }
    }
}
