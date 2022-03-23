--use Computed Columns
create table Marks(Test1 int,Test2 int,TestAvg as (Test1+Test2)/2)
--insert record to Marks table
insert into Marks values(450,540)
insert into Marks values(467,564)
--fetch records from Marks
select * from Marks
--Create table with Identity Column
Create table Printer(PrintId int identity(500,1),PrintCount int)
--insert record to Printer table
insert into Printer values(200)
insert into Printer values(120)
insert into Printer values(202)
select * from Printer

--Create table using uniqidentifier column
Create table Customer(CustomerId uniqueidentifier not null,CustomerName varchar(30))
--insert record into Customer table
insert into Customer values(NEWID(),'Rohan')
insert into Customer values(NEWID(),'Suren')
select * from Customer
