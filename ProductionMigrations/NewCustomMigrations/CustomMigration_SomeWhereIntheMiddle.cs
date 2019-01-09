
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using AdvEFCoreMigrations.Context;
using System;

namespace AdvEFCoreMigrations.Migrations
{
    [DbContext(typeof(MyCompanyDBContext))]
    [Migration("1_CustomMigration_SomeWhereIntheMiddle")]
    class CustomMigration_SomeWhereIntheMiddle : Migration
    {



        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Console.WriteLine($"Running Up in {migrationBuilder.GetMigrationId(typeof(CustomMigration_SomeWhereIntheMiddle))}");
            migrationBuilder.KeepAliveCustomMigration(migrationBuilder.GetMigrationId(typeof(CustomMigration_SomeWhereIntheMiddle)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.KeepAliveCustomMigration(migrationBuilder.GetMigrationId(typeof(CustomMigration_SomeWhereIntheMiddle)));
            // TODO: Implemnent this how you see fit
            //  base.Down(migrationBuilder);
        }
    }

}
