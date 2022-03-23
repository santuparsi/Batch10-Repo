--Create new Database
create database Batch7DB
--Set Database
use Batch7DB
--Create table
create table Person(Fname varchar(30),Lname varchar(20),Age int,City varchar(20))
drop table Person
create table Person(PersonId int primary key identity(100,1),
Fname varchar(20) not null,Lname varchar(20) not null,Age int check(Age>18 and Age<100),
City varchar(20))
create table Project(ProjectCode char(5) primary key,ProjectName varchar(30) unique)
create table Employee(EmployeeId int primary key,EmployeeName varchar(20) not null,
JoinDate date,Designation varchar(20) default 'Not Assigned',Salary int,ProjectCode char(5) foreign key 
references Project(ProjectCode))