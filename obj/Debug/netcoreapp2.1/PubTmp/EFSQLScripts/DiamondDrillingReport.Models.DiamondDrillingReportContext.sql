IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190127134800_InitialCreate')
BEGIN
    CREATE TABLE [Drill] (
        [ID] int NOT NULL IDENTITY,
        [DrillCode] nvarchar(max) NULL,
        [DrillNum] nvarchar(max) NULL,
        [DrillColour] nvarchar(max) NULL,
        [Modification] nvarchar(max) NULL,
        [DrillName] nvarchar(max) NULL,
        [Depth] float NOT NULL,
        CONSTRAINT [PK_Drill] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190127134800_InitialCreate')
BEGIN
    CREATE TABLE [Employee] (
        [ID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Surname] nvarchar(max) NULL,
        [Short] nvarchar(max) NULL,
        [NameRus] nvarchar(max) NULL,
        [Position] int NULL,
        CONSTRAINT [PK_Employee] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190127134800_InitialCreate')
BEGIN
    CREATE TABLE [Hole] (
        [ID] int NOT NULL IDENTITY,
        [HoleCode] nvarchar(max) NULL,
        [HoleZone] nvarchar(max) NULL,
        [Area] nvarchar(max) NULL,
        [DrillID] int NOT NULL,
        [HoleDepth] float NOT NULL,
        [Azimut] float NOT NULL,
        [Dip] float NOT NULL,
        [Section] float NOT NULL,
        [ZeroDatum] nvarchar(max) NULL,
        [StartDate] datetime2 NOT NULL,
        [Status] nvarchar(max) NULL,
        [ProjectCoordinatesX] float NOT NULL,
        [ProjectCoordinatesY] float NOT NULL,
        [ProjectCoordinatesZ] float NOT NULL,
        [ActualCoordinateX] float NOT NULL,
        [ActualCoordinateY] float NOT NULL,
        [ActualCoordinateZ] float NOT NULL,
        CONSTRAINT [PK_Hole] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_Hole_Drill_DrillID] FOREIGN KEY ([DrillID]) REFERENCES [Drill] ([ID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190127134800_InitialCreate')
BEGIN
    CREATE TABLE [Crew] (
        [ID] int NOT NULL IDENTITY,
        [EmployeeID] int NOT NULL,
        CONSTRAINT [PK_Crew] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_Crew_Employee_EmployeeID] FOREIGN KEY ([EmployeeID]) REFERENCES [Employee] ([ID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190127134800_InitialCreate')
BEGIN
    CREATE TABLE [CreateDailyReport] (
        [ID] int NOT NULL IDENTITY,
        [Date] datetime2 NOT NULL,
        [HoleID] int NOT NULL,
        [WaterTruckDay] nvarchar(max) NULL,
        [WaterTruckNight] nvarchar(max) NULL,
        [BitsDay] nvarchar(max) NULL,
        [BitsNight] nvarchar(max) NULL,
        [ShellDay] nvarchar(max) NULL,
        [ShellNight] nvarchar(max) NULL,
        [HoleDepthToDay] float NOT NULL,
        [HoleDepthToNight] float NOT NULL,
        [CasingFromDay] float NOT NULL,
        [CasingFromNight] float NOT NULL,
        [CasingToDay] float NOT NULL,
        [CasingToNight] float NOT NULL,
        [PreStartDay] float NOT NULL,
        [PreStartNight] float NOT NULL,
        [ConditionDay] float NOT NULL,
        [ConditionNight] float NOT NULL,
        [DrillingDay] float NOT NULL,
        [DrillingNight] float NOT NULL,
        [ReamingDay] float NOT NULL,
        [ReamingNight] float NOT NULL,
        [ReamingCasingDay] float NOT NULL,
        [ReamingCasingNight] float NOT NULL,
        [BitChangeDay] float NOT NULL,
        [BitChangeNight] float NOT NULL,
        [RepairsDay] float NOT NULL,
        [RepairsNight] float NOT NULL,
        [BlastDay] float NOT NULL,
        [BlastNight] float NOT NULL,
        [WaterDelayDay] float NOT NULL,
        [WaterDelayNight] float NOT NULL,
        [AwaitingPartsMaterialsDay] float NOT NULL,
        [AwaitingPartsMaterialsNight] float NOT NULL,
        [AwaitingMechanicElectricianDay] float NOT NULL,
        [AwaitingMechanicElectricianNight] float NOT NULL,
        [AwaitingDozerDay] float NOT NULL,
        [AwaitingDozerNight] float NOT NULL,
        [PreparationDrillingDay] float NOT NULL,
        [PreparationDrillingNight] float NOT NULL,
        [DismantlingDay] float NOT NULL,
        [DismantlingNight] float NOT NULL,
        [MovingRigDay] float NOT NULL,
        [MovingRigNight] float NOT NULL,
        [TestsDay] float NOT NULL,
        [TestsNight] float NOT NULL,
        [AwaitingDrillCrewDay] float NOT NULL,
        [AwaitingDrillCrewNight] float NOT NULL,
        [TestDayDepth] float NOT NULL,
        [TestDayDIP] float NOT NULL,
        [TestDayAZ] float NOT NULL,
        [TestDayMAG] float NOT NULL,
        [TestDayDepth2] float NOT NULL,
        [TestDayDIP2] float NOT NULL,
        [TestDayAZ2] float NOT NULL,
        [TestDayMAG2] float NOT NULL,
        [TestDayDepth3] float NOT NULL,
        [TestDayDIP3] float NOT NULL,
        [TestDayAZ3] float NOT NULL,
        [TestDayMAG3] float NOT NULL,
        [TestDayDepth4] float NOT NULL,
        [TestDayDIP4] float NOT NULL,
        [TestDayAZ4] float NOT NULL,
        [TestDayMAG4] float NOT NULL,
        [TestNightDepth] float NOT NULL,
        [TestNightDIP] float NOT NULL,
        [TestNightAZ] float NOT NULL,
        [TestNightMAG] float NOT NULL,
        [TestNightDepth2] float NOT NULL,
        [TestNightDIP2] float NOT NULL,
        [TestNightAZ2] float NOT NULL,
        [TestNightMAG2] float NOT NULL,
        [TestNightDepth3] float NOT NULL,
        [TestNightDIP3] float NOT NULL,
        [TestNightAZ3] float NOT NULL,
        [TestNightMAG3] float NOT NULL,
        [TestNightDepth4] float NOT NULL,
        [TestNightDIP4] float NOT NULL,
        [TestNightAZ4] float NOT NULL,
        [TestNightMAG4] float NOT NULL,
        [CommentDay] nvarchar(max) NULL,
        [CommentNight] nvarchar(max) NULL,
        CONSTRAINT [PK_CreateDailyReport] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_CreateDailyReport_Hole_HoleID] FOREIGN KEY ([HoleID]) REFERENCES [Hole] ([ID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190127134800_InitialCreate')
BEGIN
    CREATE INDEX [IX_CreateDailyReport_HoleID] ON [CreateDailyReport] ([HoleID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190127134800_InitialCreate')
BEGIN
    CREATE INDEX [IX_Crew_EmployeeID] ON [Crew] ([EmployeeID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190127134800_InitialCreate')
BEGIN
    CREATE INDEX [IX_Hole_DrillID] ON [Hole] ([DrillID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190127134800_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190127134800_InitialCreate', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190128114040_holeModeling')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Hole]') AND [c].[name] = N'Section');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Hole] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Hole] ALTER COLUMN [Section] float NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190128114040_holeModeling')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Hole]') AND [c].[name] = N'ProjectCoordinatesZ');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Hole] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Hole] ALTER COLUMN [ProjectCoordinatesZ] float NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190128114040_holeModeling')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Hole]') AND [c].[name] = N'ProjectCoordinatesY');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Hole] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Hole] ALTER COLUMN [ProjectCoordinatesY] float NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190128114040_holeModeling')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Hole]') AND [c].[name] = N'ProjectCoordinatesX');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Hole] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Hole] ALTER COLUMN [ProjectCoordinatesX] float NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190128114040_holeModeling')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Hole]') AND [c].[name] = N'HoleDepth');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Hole] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Hole] ALTER COLUMN [HoleDepth] float NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190128114040_holeModeling')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Hole]') AND [c].[name] = N'Dip');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Hole] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Hole] ALTER COLUMN [Dip] float NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190128114040_holeModeling')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Hole]') AND [c].[name] = N'Azimut');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Hole] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Hole] ALTER COLUMN [Azimut] float NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190128114040_holeModeling')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Hole]') AND [c].[name] = N'ActualCoordinateZ');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Hole] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [Hole] ALTER COLUMN [ActualCoordinateZ] decimal(18, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190128114040_holeModeling')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Hole]') AND [c].[name] = N'ActualCoordinateY');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Hole] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [Hole] ALTER COLUMN [ActualCoordinateY] float NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190128114040_holeModeling')
BEGIN
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Hole]') AND [c].[name] = N'ActualCoordinateX');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Hole] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [Hole] ALTER COLUMN [ActualCoordinateX] float NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190128114040_holeModeling')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190128114040_holeModeling', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190129040017_holeStatus')
BEGIN
    DECLARE @var10 sysname;
    SELECT @var10 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Hole]') AND [c].[name] = N'Status');
    IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Hole] DROP CONSTRAINT [' + @var10 + '];');
    ALTER TABLE [Hole] ALTER COLUMN [Status] int NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190129040017_holeStatus')
BEGIN
    DECLARE @var11 sysname;
    SELECT @var11 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Hole]') AND [c].[name] = N'ActualCoordinateZ');
    IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Hole] DROP CONSTRAINT [' + @var11 + '];');
    ALTER TABLE [Hole] ALTER COLUMN [ActualCoordinateZ] float NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190129040017_holeStatus')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190129040017_holeStatus', N'2.1.4-rtm-31024');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190129053025_HoleStatuses')
BEGIN
    EXEC sp_rename N'[Hole].[Status]', N'HoleStatusID', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190129053025_HoleStatuses')
BEGIN
    CREATE TABLE [HoleStatus] (
        [ID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_HoleStatus] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190129053025_HoleStatuses')
BEGIN
    CREATE INDEX [IX_Hole_HoleStatusID] ON [Hole] ([HoleStatusID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190129053025_HoleStatuses')
BEGIN
    ALTER TABLE [Hole] ADD CONSTRAINT [FK_Hole_HoleStatus_HoleStatusID] FOREIGN KEY ([HoleStatusID]) REFERENCES [HoleStatus] ([ID]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190129053025_HoleStatuses')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190129053025_HoleStatuses', N'2.1.4-rtm-31024');
END;

GO

