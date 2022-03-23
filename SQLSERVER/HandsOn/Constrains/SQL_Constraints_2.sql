Create table Standard(StandId char(5) primary key,StandName varchar(10) unique not null,timings varchar(20) null)
Create table Student(Sid int not null,Sname varchar(20),SDOB Date,StandId char(5))
--Apply constraints using alter statments
--Primary key/Unique
Alter table Student Add constraint Pk_Sid primary key(Sid)
--Check Key
Alter table Student Add constraint Uk_SDOB check(SDOB<getdate())
--Foreign key
Alter table Student add constraint Fk_StandId foreign key(StandId) references Standard(StandId)
Alter table Student add constraint Fk_StandId foreign key(StandId) references Standard(StandId)  on delete cascade
Alter table Student add constraint Fk_StandId foreign key(StandId) references Standard(StandId)  on delete set null
Alter table Student add constraint Fk_StandId foreign key(StandId) references Standard(StandId)  on delete set default
Alter table Student add constraint Fk_StandId foreign key(StandId) references Standard(StandId)  on update cascade
alter table Student Drop constraint Fk_StandId
insert into Standard values('S0001','I','1PM-3PM')
insert into Student values(1,'Raj','12.2.2017','S0001')
delete from Standard where StandId='S0001'
select * from Student
truncate table Student
