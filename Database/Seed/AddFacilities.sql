if (select count(*) from Facilities) = 0 
BEGIN
insert into Facilities (Name, Phone, TournamentId) values ('Forest Park', '1112223333', 1), ('Highland', '4445556666', 1)
END