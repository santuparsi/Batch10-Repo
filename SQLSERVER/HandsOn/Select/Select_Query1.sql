select * from Employee
insert into Employee(Eid,Ename,Salary,Desig) values(1000,'Raj',12000,'Programmer')
select *  from Employee
select Eid,Ename,Salary from Employee
select Eid,Ename,Salary from Employee where Salary>12000
select Eid,Ename,Salary from Employee where Eid=1111
select Eid,Ename from Employee where Salary>12000 and DeptId='D003'
select Eid,Ename,Salary,DeptId from Employee where Salary<=12000 or DeptId='D003'
--order the records in assedning order
select * from Employee order by Salary
select * from Employee order by Salary asc
--order the records in descending order
select * from Employee order by Ename Desc
--use distinct
select DeptId from Employee
select distinct DeptId from Employee
--eleminating duplicate rows
select distinct * from Employee