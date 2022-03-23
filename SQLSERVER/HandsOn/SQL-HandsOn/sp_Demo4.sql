create procedure UpdateProduct(@Pid int,@Price int,@Stock int)
as
begin
update Product set Price=@Price,Stock=@Stock where Pid=@Pid
end