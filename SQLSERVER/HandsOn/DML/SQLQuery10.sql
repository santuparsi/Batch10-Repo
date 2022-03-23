create table mytable(CID varchar(6) primary key check(CID like 'C%'))
insert into mytable values('S0001')
create rule Order_status_Rule
as @rule in ('Ip','B','C','F')
go
exec sp_bindrule Order_status_Rule,'Sales_Order.Order_Status'