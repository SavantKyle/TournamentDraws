CREATE TABLE [dbo].[Divisions]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
	Name varchar(200) not null, 
	DivisionGroupId int foreign key references DivisionGroups(Id)
)
