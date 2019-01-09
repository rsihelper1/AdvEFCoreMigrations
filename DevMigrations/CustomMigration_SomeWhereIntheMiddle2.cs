
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using AdvEFCoreMigrations.Context;
using System;

namespace AdvEFCoreMigrations.Migrations
{
    [DbContext(typeof(MyCompanyDBContext))]
    [Migration("2_CustomMigration_SomeWhereIntheMiddle")]
    class CustomMigration_SomeWhereIntheMiddle2 : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Console.WriteLine($"Running Up in {migrationBuilder.GetMigrationId(typeof(CustomMigration_SomeWhereIntheMiddle2))}");
            migrationBuilder.KeepAliveCustomMigration(migrationBuilder.GetMigrationId(typeof(CustomMigration_SomeWhereIntheMiddle2)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.KeepAliveCustomMigration(migrationBuilder.GetMigrationId(typeof(CustomMigration_SomeWhereIntheMiddle2)));
            // TODO: Implemnent this how you see fit
            //  base.Down(migrationBuilder);
        }
    }

}
