--Select Queries
select * from Employee
select EmployeeId,EmployeeName from Employee
select * from Employee where ProjectCode='P0001'
select * from Employee where EmployeeId=32123
select * from Employee where EmployeeId=32123 and ProjectCode='P0001'
select * from Employee where EmployeeId=32123 or ProjectCode='P0002'
select * from Employee where ProjectCode is null
select * from Employee where ProjectCode in('P0001','P0002')
select * from Employee where JoinDate between '10.1.2021' and '12.31.2021'
select * from Employee where Salary between 10000 and 30000
