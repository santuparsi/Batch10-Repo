create view vw_Emp
with Encryption
as
select Eid,Ename from Employee
go
sp_helptext vw_Emp