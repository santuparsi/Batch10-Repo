create procedure DeleteProduct(@Pid int)
as
begin
if(exists(Select * from Product where Pid=@Pid))
delete from Product where Pid=@Pid
else
print 'Invalid Product Id'
end
exec DeleteProduct @Pid=2
select * from Product
select * from Product where Pid=2