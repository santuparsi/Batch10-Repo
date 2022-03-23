select * from Employee
select Max(Salary) from Employee
select * from Employee where Salary=Max(Salary)
select * from Employee where Salary=(select Max(Salary) from Employee)
select * from Employee where ProjectCode=(Select ProjectCode from Project where ProjectName='ECommerce')
select * from Employee where  ProjectCode in(Select ProjectCode From Project)
select * from Employee where Salary>all(Select Salary from Employee where ProjectCode='P0001')