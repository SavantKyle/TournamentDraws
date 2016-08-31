CREATE TABLE [dbo].[Matchups]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
	Team1Id int foreign key references Teams(Id) not null, 
	Team2Id int foreign key references Teams(Id) not null, 
	CourtTimeId int foreign key references CourtTimes(Id) not null
)
