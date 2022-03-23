select * from Dept
insert into Dept values('D004','R&D')
--left outer join
select e.Eid,e.Ename,d.Deptname from Employee e left outer join Dept d 
on e.DeptId=d.DeptId
--right outer join
select e.Eid,e.Ename,d.Deptname from Employee e right outer join Dept d
on e.DeptId=d.DeptId
--full outer join
select e.Eid,e.Ename,d.Deptname from Employee e full outer join Dept d
on e.DeptId=d.DeptId