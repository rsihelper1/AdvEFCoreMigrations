
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using AdvEFCoreMigrations.Context;
using System;

namespace AdvEFCoreMigrations.Migrations
{
    [DbContext(typeof(MyCompanyDBContext))]
    [Migration("CustomMigration_RunEveryTime_At_END")]
    class CustomMigration_RunEveryTime_At_END : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Console.WriteLine($"Running Up in {migrationBuilder.GetMigrationId(typeof(CustomMigration_RunEveryTime_At_END))}");
            migrationBuilder.KeepAliveCustomMigration(migrationBuilder.GetMigrationId(typeof(CustomMigration_RunEveryTime_At_END)));
          }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.KeepAliveCustomMigration(migrationBuilder.GetMigrationId(typeof(CustomMigration_RunEveryTime_At_END)));
            // TODO: Implemnent this how you see fit
            //  base.Down(migrationBuilder);
        }
    }

}
