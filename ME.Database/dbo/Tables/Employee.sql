CREATE TABLE [dbo].[Employee] (
    [EmployeeID] INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (225) NOT NULL,
    [LastName]   VARCHAR (225) NOT NULL,
    [Created]    DATETIME      NOT NULL,
    [Modified]   DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);

