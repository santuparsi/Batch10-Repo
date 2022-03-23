Create procedure GetEmployeeById(@Eid int)
as
begin
SELECT * FROM EMPLOYEE WHERE EID=@Eid
end