select * from Employee
alter table Employee add Manager int foreign key references Employee(Eid)
update Employee set Manager=1232 where Eid in(1000,1111,1234,1235)
update Employee set Manager=1238 where Eid in(1240,1304)
--Self Join
--Fetch Employee Names who are assigned as Managers
select distinct e1.Ename from Employee e1 join Employee e2 on e1.Eid=e2.Manager
SELECT emp.Eid , emp.EName, mgr.EName as 'Manager'
FROM Employee emp
INNER JOIN Employee mgr
ON emp.Manager = mgr.EID
--Cross Join
select e.Ename,d.DeptName from Employee e,Dept d