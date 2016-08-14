CREATE TABLE [dbo].[Players]
(
	[Id] INT identity PRIMARY KEY NOT NULL, 
	FirstName varchar(100) not null,
	LastName varchar(100) not null, 
	Phone varchar(10), 
	Email varchar(100), 
	Ntrp decimal(2,1),
	TeamId int foreign key references Teams(Id)
)
