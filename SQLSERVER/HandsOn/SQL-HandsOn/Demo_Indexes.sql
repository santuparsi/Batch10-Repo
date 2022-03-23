select * from Employee where Eid=100
select * from Employee
select * into Emp from Employee
select * from Emp
sp_helpconstraint Emp
sp_helpconstraint Employee
sp_helpindex Employee --to list the indexes
--Create Index
Create clustered index index_Eid on Emp(Eid)
Create Nonclustered index index_salary on Emp(Salary
sp_helpindex Emp

Select * into Prod from Product where Price>10
select * from Prod
--Create Uniqe Index
Create unique clustered index index_Pid on Prod(Pid)
Create unique nonclustered index index_Pname on Prod(Pname)
sp_helpIndex Prod
--drop index
drop index index_Pname from Prod