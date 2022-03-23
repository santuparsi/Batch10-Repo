--Create View
alter view Employeeview
as
select Eid,Ename,Salary from Employee
GO
select * from Employeeview
select Eid from Employeeview
select * from Employeeview where Eid=1000
sp_helptext EmployeeView
drop view Employeeview
select * from Employee