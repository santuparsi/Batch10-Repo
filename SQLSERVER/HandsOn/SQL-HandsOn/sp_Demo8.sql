create procedure GetNameByID(@Eid int,@EName varchar(20) out)
as
begin
select @EName=Ename from Employee where Eid=@Eid
end

declare @En varchar(20)
exec GetNameByID 100,@En out
print @En