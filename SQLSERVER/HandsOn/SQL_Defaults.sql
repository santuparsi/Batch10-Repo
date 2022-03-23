Create table Person(Pid int primary key,Pname varchar(20),JoinDate Date)
--Create Default Rule
Create Default Add_Date
as getdate()
GO
exec sp_bindefault Add_Date,'Person.JoinDate'
insert into Person(Pid,Pname) values(1,'Rohan')
insert into Person(Pid,Pname) values(2,'Ram','12.2.2019')
select * from Person