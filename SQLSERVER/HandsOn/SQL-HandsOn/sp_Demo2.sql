create procedure AddProduct(@Pid int,@Pname varchar(20),@Price int,@Stock int)
as
begin
if (select count(*) from Product where Pid=@Pid)=0
insert into Product values(@Pid,@Pname,@Price,@Stock)
else
print 'ID already exist'
end
exec AddProduct 1,'keyboard',400,10
exec AddProduct 1,'mouse',500,4