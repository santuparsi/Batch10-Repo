create procedure DeleteProduct1(@Pid int)
as
begin
if(exists(Select * from Product where Pid=@Pid))
delete from product where pid=@Pid
else
Raiserror('Invalid Id',14,1)
end
exec DeleteProduct1 1000

Create procedure AddDept1(@Did varchar(20),@DName varchar(20))
as
begin
begin try
insert into Dept values(@Did,@DName)
end try
begin catch
Raiserror('Record exist',16,1)
end catch
end
exec AddDept1 'D001','HR'

