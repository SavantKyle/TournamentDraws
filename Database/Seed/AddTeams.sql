if (select count(*) from Teams) = 0 
BEGIN
insert into Teams (Name, RatingId, TournamentId) values ('K1', 4, 1), ('K2', 4, 1), ('K3', 4, 1), ('K4', 4, 1), ('KS1', 4, 1), ('KS2', 4, 1), ('KS3', 4, 1), ('KS4', 4, 1)
END