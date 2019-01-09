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

