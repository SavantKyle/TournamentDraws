if (select count(*) from Courts) = 0 
BEGIN
insert into Courts (Name, FacilityId) values ('Court 1', 1)
END