Create procedure DeleteEmployee(@Eid int)
as
begin
Delete from Employee where Eid=@Eid
End