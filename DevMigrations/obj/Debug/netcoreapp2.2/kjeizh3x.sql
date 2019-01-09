IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO


                    BEGIN TRY
                     DROP TRIGGER [dbo].[__EFMigrationsHistory_0_CustomMigration_RunEveryTime_At_START]
                    END TRY

                    BEGIN CATCH

                    END CATCH        
            

GO


                    CREATE TRIGGER [dbo].[__EFMigrationsHistory_0_CustomMigration_RunEveryTime_At_START] ON  [dbo].[__EFMigrationsHistory]
                    AFTER INSERT
                    AS 
                    BEGIN
                        if (select count(*) from inserted where MigrationId='0_CustomMigration_RunEveryTime_At_START') >=1
                        BEGIN
	                        delete from [dbo].[__EFMigrationsHistory] where MigrationId='0_CustomMigration_RunEveryTime_At_START'
                        END
                    END        
               

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'0_CustomMigration_RunEveryTime_At_START', N'2.2.0-rtm-35687');

GO


                    BEGIN TRY
                     DROP TRIGGER [dbo].[__EFMigrationsHistory_1_CustomMigration_SomeWhereIntheMiddle]
                    END TRY

                    BEGIN CATCH

                    END CATCH        
            

GO


                    CREATE TRIGGER [dbo].[__EFMigrationsHistory_1_CustomMigration_SomeWhereIntheMiddle] ON  [dbo].[__EFMigrationsHistory]
                    AFTER INSERT
                    AS 
                    BEGIN
                        if (select count(*) from inserted where MigrationId='1_CustomMigration_SomeWhereIntheMiddle') >=1
                        BEGIN
	                        delete from [dbo].[__EFMigrationsHistory] where MigrationId='1_CustomMigration_SomeWhereIntheMiddle'
                        END
                    END        
               

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'1_CustomMigration_SomeWhereIntheMiddle', N'2.2.0-rtm-35687');

GO


                    BEGIN TRY
                     DROP TRIGGER [dbo].[__EFMigrationsHistory_2_CustomMigration_SomeWhereIntheMiddle]
                    END TRY

                    BEGIN CATCH

                    END CATCH        
            

GO


                    CREATE TRIGGER [dbo].[__EFMigrationsHistory_2_CustomMigration_SomeWhereIntheMiddle] ON  [dbo].[__EFMigrationsHistory]
                    AFTER INSERT
                    AS 
                    BEGIN
                        if (select count(*) from inserted where MigrationId='2_CustomMigration_SomeWhereIntheMiddle') >=1
                        BEGIN
	                        delete from [dbo].[__EFMigrationsHistory] where MigrationId='2_CustomMigration_SomeWhereIntheMiddle'
                        END
                    END        
               

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'2_CustomMigration_SomeWhereIntheMiddle', N'2.2.0-rtm-35687');

GO

ALTER TABLE [Employees] ADD [moretasks] nvarchar(max) NULL;

GO

ALTER TABLE [Employees] ADD [tasks] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190108183827_TestSnapshottoEmployee', N'2.2.0-rtm-35687');

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Employees]') AND [c].[name] = N'moretasks');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Employees] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Employees] DROP COLUMN [moretasks];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190109003055_AddHireDateToEmployee', N'2.2.0-rtm-35687');

GO


                    BEGIN TRY
                     DROP TRIGGER [dbo].[__EFMigrationsHistory_CustomMigration_RunEveryTime_At_END]
                    END TRY

                    BEGIN CATCH

                    END CATCH        
            

GO


                    CREATE TRIGGER [dbo].[__EFMigrationsHistory_CustomMigration_RunEveryTime_At_END] ON  [dbo].[__EFMigrationsHistory]
                    AFTER INSERT
                    AS 
                    BEGIN
                        if (select count(*) from inserted where MigrationId='CustomMigration_RunEveryTime_At_END') >=1
                        BEGIN
	                        delete from [dbo].[__EFMigrationsHistory] where MigrationId='CustomMigration_RunEveryTime_At_END'
                        END
                    END        
               

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'CustomMigration_RunEveryTime_At_END', N'2.2.0-rtm-35687');

GO

