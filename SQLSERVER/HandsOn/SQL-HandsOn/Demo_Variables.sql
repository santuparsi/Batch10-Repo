--variables in sqlserver
declare @Ename varchar(20)
declare @Price int
declare @DOB Date
--assign values to variables
set @Ename='Rohith'
set @Price=100
set @DOB='12.2.2000'
--assign value to multiple varaibles using one statemetn
select @Ename='John',@Price=200,@DOB='2.23.1998'

declare @a int
declare @b int
declare @result int
select @a=10,@b=20
set @result=@a+@b
print @result