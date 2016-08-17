CREATE TABLE [dbo].[Ratings]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
	NtrpRating decimal(2,1) not null,
	RatingType int not null 
)
