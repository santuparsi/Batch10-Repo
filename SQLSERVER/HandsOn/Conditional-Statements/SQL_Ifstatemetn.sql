--if-condition
declare @a int
set @a=10
if(@a%2=0)
print 'even value'
else
print 'odd value'