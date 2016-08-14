CREATE TABLE [dbo].[Addresses]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
	Street1 varchar(300) not null, 
	Street2 varchar(100), 
	City varchar(100) not null, 
	State varchar(100) not null, 
	Zip varchar(5) not null, 
	PlayerId int foreign key references Players(Id), 
	FacilityId int foreign key references Facilities(Id)
)
