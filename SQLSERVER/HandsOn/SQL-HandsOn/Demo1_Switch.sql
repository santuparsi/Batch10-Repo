select * from Employee
select Ename,Salary,case
when salary=12000 then 1000
when salary=23000 then 2000
end as 'Bonous' from Employee