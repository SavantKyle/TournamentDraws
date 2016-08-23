CREATE TABLE [dbo].[DivisionGroups]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
	Name varchar(200) not null, 
	RatingId int foreign key references Ratings(Id) not null
)
