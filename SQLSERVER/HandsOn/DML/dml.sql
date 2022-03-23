--Add records
insert into Person values('Rahul','Dravid',38,'Bangalore')
insert into Person values('Virat','Kohili',34,'Delhi')
--update records
update Person set Age=43 where PersonId=100
update Person set Lname='Kohli',Age=35 where PersonId=101
--Delete Records
Delete from Person where PersonId=100
select * from Person
insert into Project values('P0001','HealthCare')
insert into Project values('P0002','ECommerce')
insert into Project values('P0003','Insurence')
select * from Project
insert into Employee values(32123,'Akash','12.12.2021','Trainee',12000,'P0001')
insert into Employee(EmployeeId,EmployeeName,JoinDate,Salary)
values(78989,'Deepak','12.12.2021',12000)
select * from Employee
insert into Employee values(32124,'Repesh','12.12.2021','Trainee',12000,'P0001')
insert into Employee values(32125,'Anshu','12.12.2021','Trainee',12000,'P0002')
insert into Employee values(32126,'Divya','12.12.2021','Trainee',12000,'P0001')
insert into Employee values(32127,'Rishab','12.12.2021','Trainee',12000,'P0002')
insert into Employee values(32128,'Shreyanshi','12.12.2021','Trainee',12000,'P0001')
insert into Employee values(32129,'Dawal','12.12.2021','Trainee',12000,'P0002')
insert into Employee values(32130,'Mounica','01.12.2021','Trainee',12000,'P0002')
update Employee set Salary=32000 where EmployeeId=32130