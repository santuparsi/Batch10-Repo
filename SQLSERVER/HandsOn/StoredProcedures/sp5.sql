create table Login(Eid int foreign key references Employee(Eid),Uname varchar(20) primary key,Pwd varchar(20))
select * from Employee
--adding multiple records
insert into Login(Eid,Uname,Pwd) select 1000,'Raj','12345' union
select 1111,'John','12345' union
select 1234,'Rohan123','12345'
select * from Login
alter procedure Validate(@Uname varchar(20),@Pwd varchar(20))
as
begin
if((select count(*) from Login where Uname=@uname and Pwd=@Pwd)<>0)
return 1
else
return 0
end
declare @res int
exec @res=Validate @uname='John',@Pwd='1234'
if(@res=1)
print 'Valid User'
else
print 'Invalid User'