--SubQuery =,<>,>,<,>=,<=
select * from Employee where Salary=(Select Max(Salary) from Employee)
select * from Employee where DeptId=(select DeptId from Dept where DeptName='HR')
--List out Employees assigned to Dept in,any,all,not in
select * from Employee where DeptId in(Select DeptId from Dept)
select * from Employee
--Get Employees who are having more than Salary of All HR Employees
select * from Employee where Salary>All(Select Salary from Employee where DeptId='D003')
select * from Employee where Salary>Any(Select Salary from Employee where DeptId='D003') and DeptId<>'D003'
update Employee set Salary=Salary+Salary*0.1 where DeptId=(Select DeptId from Dept where DeptName='HR')
--get 2nd heightest employee salary details
select * from Employee where Salary=(Select Max(Salary) from Employee where Salary<(Select Max(Salary) from Employee))
select * from Employee where exists(Select Eid From Employee where Ename='rishna')