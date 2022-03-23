Create table Printer(Printer_ID int identity(100,1) not null,
Printer_Name varchar(20) not null)
insert into Printer values('Canon')
insert into Printer values('Nikkon')
insert into Printer values(200,'ABC')
select * from Printer
Create table Customer(Customer_Id uniqueidentifier not null,Customer_Name varchar(20) not null)
insert into Customer values(NEWID(),'Rohan')
select * from Customer