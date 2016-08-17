if (select count(*) from Divisions) = 0 
BEGIN
insert into Divisions (Description, DivisionGroupId) values ('Red', 1), ('Green', 2)
END