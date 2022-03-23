--Date Functions
select getdate()
select Year('12.2.2000')
select Month('12.2.2000')
select Day('12.2.2000')
select DATEPART(yy,'12.2.2019')
select DATEPART(mm,'12.2.2019')
select DATEPART(dd,'12.2.2019')
select DATEPART(dw,getdate())
select DATEPART(hh,getdate())
select DATEPART(MI,getdate())
select DATEPART(SS,getdate())

select DateName(dw,getdate())
select DateName(mm,getdate())

select DATEDIFF(yy,'12.2.1990',getdate())
select DATEDIFF(MM,'12.2.1990',getdate())
select DATEDIFF(DD,'12.2.1990',getdate())

Select DATEADD(DD,1,getdate())