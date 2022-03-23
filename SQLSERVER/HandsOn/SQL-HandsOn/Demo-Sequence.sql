CREATE SEQUENCE SQ1 AS INT
START WITH 100
INCREMENT BY 25
MINVALUE 100
MAXVALUE 200
CYCLE
CACHE 10
GO
create table myTable
(sid int, Sname varchar(15))
INSERT INTO myTable(sid, sname)
VALUES (NEXT VALUE FOR Sq1, 'Tom');INSERT INTO myTable(sid, sname)
VALUES (NEXT VALUE FOR Sq1, 'Tom');INSERT INTO myTable(sid, sname)
VALUES (NEXT VALUE FOR Sq1, 'Tom');INSERT INTO myTable(sid, sname)
VALUES (NEXT VALUE FOR Sq1, 'Tom');INSERT INTO myTable(sid, sname)
VALUES (NEXT VALUE FOR Sq1, 'Tom');INSERT INTO myTable(sid, sname)
VALUES (NEXT VALUE FOR Sq1, 'Tom');select * from myTable