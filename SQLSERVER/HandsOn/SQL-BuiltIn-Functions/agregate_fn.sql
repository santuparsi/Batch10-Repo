select count(*)  from Employee
select count(*) as 'TotlaEmployees'  from Employee
select COUNT(*) from Employee where ProjectCode='P0001'
select COUNT(*) from Employee where Salary>12000
select Max(Salary) from Employee
select Min(Salary) from Employee
select Sum(Salary) as 'TotalSalary' from Employee
select Sum(Salary) as 'TotalSalary' from Employee where 
ProjectCode='P0001'
select Avg(Salary) as 'Avg Salary' from Employee