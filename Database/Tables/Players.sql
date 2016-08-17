CREATE TABLE [dbo].[Players]
(
	[Id] INT identity PRIMARY KEY NOT NULL, 
	FirstName varchar(100) not null,
	LastName varchar(100) not null, 
	Phone varchar(10), 
	Email varchar(100), 
	RatingId int foreign key references Ratings(Id) not null,
	TeamId int foreign key references Teams(Id) not null,
	AddressId int foreign key references Addresses(Id) 
)
