ALTER TABLE dbo.Customer
ADD
CONSTRAINT DF_contactname DEFAULT 'UNKNOWN' 
FOR Customer_Name
insert into Customer(Customer_Id) values(NEWID())
select * from Customer
Create table Orders(OrderId int identity (100,10),Order_Name varchar(20) not null,
Order_Date date default getdate())
insert into Orders(Order_Name) values('Mobile')
insert into Orders values('AirPods','12.2.2021') --mm.dd.yy
insert into Orders values('AirPods Pro','2021.2.21')--yy.mm.dd
select * from Orders
Create table Product(Pid int identity (1,1),Pname varchar(20) not null,
Price int check(Price>0))
insert into Product values('Mouse',300)
create table Employee(Eid int identity(100,1),Ename varchar(20) not null,
Desig varchar(20) check(Desig in('Programmer','Developer','Sr Developer')))
insert into Employee values('Rohan','Sr Developer')
drop table Employee