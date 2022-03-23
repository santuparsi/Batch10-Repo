begin try
insert into Product values(1,'abc',10,10)
end try
begin catch
print 'error occured'
print error_message()
end catch