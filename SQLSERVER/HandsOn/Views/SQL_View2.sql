create view EmpDeptView
as
select e.Eid,e.Ename,e.Salary,d.DeptName from Employee e join Dept d on e.DeptId=d.DeptId 
GO
select * from EmpDeptView
select Eid,Ename from EmpDeptView