CREATE TABLE [dbo].[MatchDateTimes]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
	DateTimeOfPlay datetime not null, 
	IsAvailable bit not null, 
	CourtId int foreign key references Courts(Id) not null
)
