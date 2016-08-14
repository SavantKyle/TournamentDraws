CREATE TABLE [dbo].[Directors]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
	FirstName varchar(100) not null, 
	LastName varchar(100) not null, 
	Phone varchar(10), 
	Email varchar(100),
	TournamentId int foreign key references Tournaments(Id)
)
