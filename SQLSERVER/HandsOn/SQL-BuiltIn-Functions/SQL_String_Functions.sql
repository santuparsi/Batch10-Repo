--String Functions
select str(1) 
select str(100)
select REPLACE('Hello Users','Hello','Good Morning'
select REPLACE('Hello Users','l','L')
select Left('Hello Users',4)
select Left(Ename,2) from Employee
select RIGHT('Hello Users',3)
select Right(Ename,2) from Employee
select UPPER('Hello World')
select UPPER(Ename) as 'EName',Upper(Desig) as 'Desig' from Employee
select Lower(Ename) as 'Ename',Lower(Desig) as 'Desig' from Employee
select len('Hello World')
select len(Ename) from Employee
select * from Employee where len(Ename)>5
select REVERSE('Hello World')
select SUBSTRING('Hello World',1,5)
select SUBSTRING('Hello World',2,5)
select 'Good Morning '+Ename from Employee