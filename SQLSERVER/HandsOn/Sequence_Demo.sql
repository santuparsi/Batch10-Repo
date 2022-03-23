--Create Sequence
Create Sequence sq1 as int
start with 10
increment by 5
go
select next value for sq1
create table myTable(Sid int,Sname varchar(20))
insert into myTable values(next value for sq1,'Suren')
select * from myTable