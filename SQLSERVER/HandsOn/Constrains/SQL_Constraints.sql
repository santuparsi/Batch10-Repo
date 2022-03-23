Create table Dept(DeptId char(5) primary key ,DetpName varchar(20) unique not null)
insert into Dept values('D001','Admin')
insert into Dept values('D002','HR')
insert into Dept values('D003','Accounts')
select * from Dept
Create table Employee(Eid int primary key,
Ename varchar(20) not null,Joindate Date check(Joindate<=getdate()),
Desig varchar(20) default 'UnAssigned',Salary money check(Salary>0),
DeptId char(5) foreign key references Dept(DeptId))
insert into Employee values(1239,'Krishna','2.12.2021','Programmer',10000,'D002')
insert into Employee(Eid,Ename,Joindate,Salary) values(1304,'Krishna',getdate(),12000)
select * from Employee
delete from Dept where DeptId='D001'
