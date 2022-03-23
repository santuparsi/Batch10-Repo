create view vw_product
with schemabinding
as
select Pid,Pname from dbo.Product
Go
sp_depends vw_Product
drop table Product