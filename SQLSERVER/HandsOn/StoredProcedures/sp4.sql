--Return a value from procedure
create procedure AddNumbers(@a int,@b int)
as
begin
declare @c int
set @c=@a+@b
return @c
end
declare @res int
exec @res=AddNumbers @a=10,@b=20
print @res