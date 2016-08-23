CREATE TABLE [dbo].[Courts]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
	Name varchar(100) not null, 
	FacilityId int foreign key references Facilities(Id) not null
)
