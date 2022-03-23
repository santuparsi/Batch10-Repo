create view vw_Employee
as
select Eid,Ename,Desig from Employee
Go
select * from vw_Employee
select Eid,Ename from vw_Employee
select * from vw_Employee where Desig='Programmer'
update vw_Employee set Desig='Sr Programmer' where Eid=100
select * from Employee