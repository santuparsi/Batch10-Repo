--Return value
create procedure CountEmpByDept(@Did varchar(20))
as
begin
declare @total int
select @total=count(*) from Employee where Did=@Did
return @total
end

declare @a int
exec @a=CountEmpByDept 'D002'
print @a

exec CountEmpByDept 'D001'
