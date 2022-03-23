Create table Employee(Eid int primary key,Ename varchar(20) not null,
Desig varchar(20) check(Desig in('Programmer','Sr Programmer','TeamLead')))
insert into Employee values(1020,'Rohan','Programmer')
insert into Employee values(1111,'Karan','TeamLead')
insert into Employee values(1000,'Suren','TeamLead')
select * from Employee
Create table Dept(Did varchar(20) primary key,Dname varchar(20) unique not null)
insert into Dept values('D001','IT')
insert into Dept values('D002','Sales')
Drop table Employee
Create table Employee(Eid int primary key,Ename varchar(20) not null,
Desig varchar(20) check(Desig in('Programmer','Sr Programmer','TeamLead')),
Did Varchar(20) foreign key references Dept(Did))
Insert into Employee values(100,'Suman','Programmer','D001')
delete from Dept where Did='D001'
--cascade referential integrity
--On Delete set CasCade
Create table Employee(Eid int primary key,Ename varchar(20) not null,
Desig varchar(20) check(Desig in('Programmer','Sr Programmer','TeamLead')),
Did Varchar(20) foreign key references Dept(Did) on Delete cascade)
Create table Employee(Eid int primary key,Ename varchar(20) not null,
Desig varchar(20) check(Desig in('Programmer','Sr Programmer','TeamLead')),
Did Varchar(20) foreign key references Dept(Did) on Update cascade on delete cascade)
select * from Employee
--On Delete set Null
Create table Employee(Eid int primary key,Ename varchar(20) not null,
Desig varchar(20) check(Desig in('Programmer','Sr Programmer','TeamLead')),
Did Varchar(20) foreign key references Dept(Did) on Delete set null)
--On Delete Set Default
Create table Employee(Eid int primary key,Ename varchar(20) not null,
Desig varchar(20) check(Desig in('Programmer','Sr Programmer','TeamLead')),
Did Varchar(20) foreign key references Dept(Did) on Delete set default)