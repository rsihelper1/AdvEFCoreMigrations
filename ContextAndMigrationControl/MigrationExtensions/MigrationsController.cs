﻿using AdvEFCoreMigrations.Context;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AdvEFCoreMigrations.Migrations
{
    public static class CustomMigrationsController
    {
        public static void KeepAliveCustomMigration(this MigrationBuilder migrationBuilder, string customMigrationName)
        {
            migrationBuilder.Sql($@"
                    BEGIN TRY
                     DROP TRIGGER [dbo].[__EFMigrationsHistory_{customMigrationName}]
                    END TRY

                    BEGIN CATCH

                    END CATCH        
            ");
            migrationBuilder.Sql($@"
                    CREATE TRIGGER [dbo].[__EFMigrationsHistory_{customMigrationName}] ON  [dbo].[__EFMigrationsHistory]
                    AFTER INSERT
                    AS 
                    BEGIN
                        if (select count(*) from inserted where MigrationId='{customMigrationName}') >=1
                        BEGIN
	                        delete from [dbo].[__EFMigrationsHistory] where MigrationId='{customMigrationName}'
                        END
                    END        
               ");
        }

        public static string  GetMigrationId(this MigrationBuilder migrationBuilder, Type t)
        {
            MigrationAttribute MyAttribute = (MigrationAttribute)Attribute.GetCustomAttribute(t, typeof(MigrationAttribute)); 
            return MyAttribute.Id;
        }

        public static Microsoft.EntityFrameworkCore.Migrations.Operations.Builders.OperationBuilder<Microsoft.EntityFrameworkCore.Migrations.Operations.SqlOperation>
            AddColumn2<t>(this MigrationBuilder migrationBuilder, string name, string table, string type = null, Nullable<bool> unicode = null, Nullable<int> maxLength = null, bool rowVersion = false, string schema = null, bool nullable = false, object defaultValue = null, string defaultValueSql = null, string computedColumnSql = null, Nullable<bool> fixedLength = null)
        {

            if(typeof(t) == typeof(string))  // Add more for other native types
              {
                type = "NVARCHAR(MAX)";
            }
           
            string nullString = "NULL";  // Check for other properties.

            if (nullable == false)
                nullString = "NOT NULL";

            string schemaString = "";
            if (schema != null)
            {
                schemaString = $"[{schema}].";
            }

            return migrationBuilder.Sql($@"
                  IF NOT EXISTS 
                (
                    SELECT * 
                    FROM INFORMATION_SCHEMA.COLUMNS 
                    WHERE table_name = '{table}'
                    AND column_name = '{name}'
                )
                BEGIN
                    ALTER TABLE {schemaString}[{table}]
                                ADD [{name}] {type} {nullString}
                END
            ELSE
                BEGIN

                 print 'Column [{name}] already exists in Table [{schema}].[{table}]'

                END
            ");
        }

    }
}
