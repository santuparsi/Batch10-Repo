--copy table
select * into Emp from Employee
select * from Emp
create view EmpView
with schemabinding
as
select Eid,Ename,JoinDate from dbo.Emp
go
select * from EmpView
drop view EmpView
drop table EMp--it can not be delated,becuse EmpView dept on Emp