create view vw_EmpDept
as
select e.Eid,e.Ename,e.Did,d.Dname from Employee e join Dept d
on e.Did=d.Did
Go
select * from vw_EmpDept

--show the view_schema
sp_helptext vw_EmpDept
sp_helptext vw_Employee
--show table dependency in a view
sp_depends vw_EmpDept
sp_depends vw_Employee