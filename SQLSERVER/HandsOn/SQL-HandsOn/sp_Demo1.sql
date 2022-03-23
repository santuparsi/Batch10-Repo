create procedure GetEmployees
as
begin
select * from Employee
end

exec GetEmployees