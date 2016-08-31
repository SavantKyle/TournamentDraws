CREATE TABLE [dbo].[CourtTimes]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
	StartTime datetime not null, 
	IsAvailable bit not null, 
	CourtId int foreign key references Courts(Id) not null
)
