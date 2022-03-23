--create table Product(Pid int primary key,Pname varchar(20) unique,Price int,Stock int)
Create procedure dbo.AddProduct(@Pname varchar(20),@Price int,@Stock int)
as
begin
declare @Pid int
if(exists(select * from Product))
begin
Select @Pid=Max(Pid) from Product
set @Pid=@Pid+1
end
else
begin
set @Pid=1
end
insert into Product values(@Pid,@Pname,@Price,@Stock)
end
exec AddProduct 'Keyboard',400,10
exec AddProduct 'Mouse',300,10
exec AddProduct 'Pendrive',500 --compilation error
select * from Product