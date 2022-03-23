--Group By
select * from Employee
select Salary,count(Salary) as 'No of EMployees' from Employee group by Salary
select DeptId,count(DeptId) as 'No of Employees' from Employee where DeptId is not null group by DeptId
--get more than one employee working in dept
select DeptId,count(DeptId) as 'No of Employees' from Employee where DeptId is not null group by Deptid having count(deptId)>1
--Sum of Salary of Each Dept
select DeptId,sum(Salary) as 'Total Salary' from Employee where DeptId is not null group by DeptId

USE pubs;
GO
select pub_id, type, avg(price), sum(ytd_sales)
from titles
group by pub_id, type
select type, avg(price), sum(ytd_sales)
from titles
group by typeselect type, sum(advance)
from titles
group by type;