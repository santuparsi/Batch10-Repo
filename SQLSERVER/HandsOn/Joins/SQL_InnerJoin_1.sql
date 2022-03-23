select * from Employee
select * from Dept
--inner join
select e.Eid,e.Ename,e.Desig,e.Salary,d.DeptName from Employee e
inner join dept d on e.DeptId=d.DeptId
--inner join with where clouse
select e.Eid,e.Ename,e.Desig,e.Salary,d.DeptName from Employee e
inner join dept d on e.DeptId=d.DeptId where e.Desig='Programmer'
select e.Eid,e.Ename,e.Desig,e.Salary,d.DeptName from Employee e
inner join dept d on e.DeptId=d.DeptId where e.Eid=1111
select e.Eid,e.Ename,e.Desig,e.Salary,d.DeptName from Employee e
inner join dept d on e.DeptId=d.DeptId where e.Desig='Programmer' order by e.Salary


