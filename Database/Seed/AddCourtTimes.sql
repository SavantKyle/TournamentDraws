if (select count(*) from CourtTimes) = 0 
BEGIN
insert into CourtTimes (StartTime, CourtId, IsAvailable) 
values 
('10/1/2016 8am', 1, 1), ('10/1/2016 9:30am', 1, 1), ('10/1/2016 11am', 1, 1), ('10/1/2016 12:30pm', 1, 1), ('10/1/2016 2pm', 1, 1), ('10/1/2016 3:30pm', 1, 1)
END