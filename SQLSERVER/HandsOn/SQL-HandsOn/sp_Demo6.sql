Create procedure GetProductById(@Pid int)
as
begin
if exists(Select * from Product where Pid=@Pid)
select * from Product where Pid=@Pid
else
print 'Id Not exist'
end