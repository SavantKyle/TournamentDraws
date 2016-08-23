CREATE TABLE [dbo].[Matchups]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
	MatchStart date not null, 
	Team1Id int foreign key references Teams(Id) not null, 
	Team2Id int foreign key references Teams(Id) not null, 
	FacilityId int foreign key references Facilities(Id) not null, 
	CourtId int foreign key references Courts(Id) not null, 
	MatchDateTimeId int foreign key references MatchDateTimes(Id) not null
)
