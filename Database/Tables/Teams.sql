CREATE TABLE [dbo].[Teams]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
	Name varchar(100) not null, 
	DivisionId int foreign key references Divisions(Id)
)
