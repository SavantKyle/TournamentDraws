CREATE TABLE [dbo].[Matchups]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
	MatchStart date not null, 
	Team1Id int foreign key references Teams(Id) not null, 
	Team2Id int foreign key references Teams(Id) not null, 
	FacilityId int foreign key references Facilities(Id) not null 
)
