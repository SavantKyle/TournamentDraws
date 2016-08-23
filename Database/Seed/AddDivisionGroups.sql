if (select count(*) from DivisionGroups) = 0 
BEGIN
insert into DivisionGroups (Name, RatingId) values ('Men 18 & Over', 4), ('Women 18 & Over', 4)
END