if (select count(*) from Players) = 0 
BEGIN
insert into Players (FirstName, LastName, Email, Phone, RatingId, TeamId) values 
('Kyle', 'Savant', 'a@b.com', '1112223333', 4, 1),
('Kelly', 'Savant', 'c@d.com', '4445556666', 4, 1)
END