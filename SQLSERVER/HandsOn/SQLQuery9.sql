select * from Employee
--add value to all the columns
insert into Employee values(1232,'Bheem',getdate(),'Programmer',12000,'D003')
--add specific column values
insert into Employee(Eid,Ename,Desig,Salary) values(1111,'John','TeamLead',23000)

--Update Record
update Employee set Joindate=getdate(),DeptId='D001' where Eid=1111
update Employee set Salary=Salary+2000 where Desig='Programmer'

--Delete Record
Delete from Employee where Eid=1304 --delete row
Delete from Employee where Desig='Programmer'