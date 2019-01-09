
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using AdvEFCoreMigrations.Context;
using System;

namespace AdvEFCoreMigrations.Migrations
{
    [DbContext(typeof(MyCompanyDBContext))]
    [Migration("0_CustomMigration_RunEveryTime_At_START")]
    class CustomMigration_RunEveryTime_At_START : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Console.WriteLine($"Running Up in {migrationBuilder.GetMigrationId(typeof(CustomMigration_RunEveryTime_At_START))}");
            migrationBuilder.KeepAliveCustomMigration(migrationBuilder.GetMigrationId(typeof(CustomMigration_RunEveryTime_At_START)));
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.KeepAliveCustomMigration(migrationBuilder.GetMigrationId(typeof(CustomMigration_RunEveryTime_At_START)));
            // TODO: Implemnent this how you see fit
            //  base.Down(migrationBuilder);
        }
    }

}
