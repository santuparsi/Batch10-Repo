--Create Database
create database Training1DB
--chage to default db
use Training1DB
--Crete table
create table Employee(Employee_Code int not null,
Employee_Name varchar(20) not null,
Employee_DOB Date not null,
Employee_EmailID varchar(20) null)
insert into Employee values(1,'Rohan','12.2.1990',null)
insert into Employee values(2,'karan','12.2.1990','karan@gmail.com')
insert into Employee values(3,'Ram',null,null)
truncate table Employee
--Alter table(Chage structure/schema) of the table
alter table Employee add Employee_Salary money not null
--Remove column
alter table Employee drop column Employee_Salary
--modify column type
alter table Employee alter column Employee_Name varchar(40)
alter table Employee alter column Employee_DOB Date null