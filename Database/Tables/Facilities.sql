CREATE TABLE [dbo].[Facilities]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
	Name varchar(100) not null, 
	Phone varchar(10), 
	AddressId int foreign key references Addresses(Id), 
	TournamentId int foreign key references Tournaments(Id)
)
