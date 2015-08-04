CREATE TABLE [dbo].[Table]
(
	[PatientID] INT NOT NULL PRIMARY KEY, 
    [Surname] CHAR(30) NULL , 
    [FirstName] CHAR(30) NULL , 
    [Gender] CHAR NULL , 
    [WardName] CHAR(20) NULL , 
    [DateOfBirth] DATE NULL, 
    [InPatient] BIT NULL
)
