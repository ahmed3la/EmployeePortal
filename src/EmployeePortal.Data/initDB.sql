IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [EmployeeTypes] (
    [Id] int NOT NULL IDENTITY,
    [EmpType] nvarchar(max) NULL,
    CONSTRAINT [PK_EmployeeTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Employees] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [JobDescription] nvarchar(max) NULL,
    [Number] nvarchar(max) NULL,
    [Department] nvarchar(max) NULL,
    [HourlyPay] float NOT NULL,
    [Bonus] float NOT NULL,
    [EmployeeTypeId] int NOT NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Employees_EmployeeTypes_EmployeeTypeId] FOREIGN KEY ([EmployeeTypeId]) REFERENCES [EmployeeTypes] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Employees_EmployeeTypeId] ON [Employees] ([EmployeeTypeId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200706202446_initDB', N'3.1.5');

GO

