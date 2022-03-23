--Switch Condition
declare @Month int
set @Month=Month(GetDate())
Select case @Month  
when 1 then 'Jan'
when 2 then 'Feb'
when 3 then 'March'
when 4 then 'Apr'
when 5 then 'May'
when 6 then 'Jun'
when 7 then 'Jul'
when 8 then 'Aug'
when 9 then 'Sept'
when 10 then 'Oct'
when 11 then 'Nov'
when 12 then 'Dec' 
end as 'Month Name'