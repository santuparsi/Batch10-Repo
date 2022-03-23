Drop table Customer
Create table Customer(Cid int identity (1,1),Cname varchar(20),City varchar(20))
--Create Default
create default city_default
as 'Banglore'
--apply default
exec sp_bindefault city_default,'Customer.City'
insert into Customer(Cname) values('Kim')
select * from Customer
create rule city_rule
as @city in('Banglore','Chennai','Hyderabad')
exec sp_bindrule city_rule,'Customer.City'
insert into Customer values('Tim','Chennai')