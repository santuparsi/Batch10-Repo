--Create Procedure to return no of EMployees working in a DeptId
Create Procedure GetEmployeesByDeptId(@DId varchar(20),@count int out)
as
begin
select @count=count(*) from Employee where DeptId=@DId
end
declare @res int
exec GetEmployeesByDeptId 'D002',@res output
print @res