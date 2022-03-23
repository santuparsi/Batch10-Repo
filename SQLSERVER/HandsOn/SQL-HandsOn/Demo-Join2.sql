Select * from Dept
select * from Employee
--Left outer join
Select E.Ename,D.DeptName from Employee E left outer join
Dept D on E.DeptId=D.DeptId
--Right outer join
Select E.Ename,D.DeptName from Employee E right outer join
Dept D on E.DeptId=D.DeptId
--Full outer join
Select E.Ename,D.DeptName from Employee E full outer join
Dept D on E.DeptId=D.DeptId
--Cross Join
Select E.Ename,D.DeptName from Employee E,Dept D where E.Ename='Raj'