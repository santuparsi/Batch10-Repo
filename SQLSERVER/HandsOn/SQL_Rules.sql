create rule desig_rule
as @ in('Programmer','TeamLead','Sr Programmer')
Go
create rule age_rule
as @age>0 and @age<100
GO
exec sp_bindrule desig_rule,'Employee.desig'
insert into Employee values(1240,'Kishan','2.12.2021','TeamLead',45000,'D002')