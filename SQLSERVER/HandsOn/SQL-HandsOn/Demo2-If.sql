declare @emp_type varchar(20)
set @emp_type='On Role'
if @emp_type='Contract'
begin
print 'Employee has PF'
print 'Employee has Medical Insurence'
end
else
begin
print 'Employee not provided any Medical Insurence'
print 'Employee does not have any paid leaves'
end