select * from Employee
create view vw_Emp1
as
select * from Employee where Did='D002' with check option
Go
drop view vw_Emp1
insert into vw_Emp1 values(123,'Joy','Programmer','D002',12000)
insert into vw_Emp1 values(124,'Uday','Programmer','D001',12000)
update vw_Emp1 set Did='D001' where Eid=123