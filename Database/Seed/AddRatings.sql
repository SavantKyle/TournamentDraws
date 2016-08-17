if (select count(*) from Ratings) = 0 
BEGIN
insert into Ratings (NtrpRating, RatingType) values (2.5,0),(3.0,0),(3.5,0),(4.0,0),(4.5,0),(5.0,0)
END