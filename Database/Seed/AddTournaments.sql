if (select count(*) from Tournaments) = 0 
BEGIN
insert into Tournaments (Name) values ('Tournament 1'), ('Tournament 2')
END