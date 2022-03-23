create procedure DeleteProduct(@Pid int)
as
begin
delete from Product where Pid=@Pid
end
exec DeleteProduct @Pid=1