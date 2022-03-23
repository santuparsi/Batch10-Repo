sp_tables
select * from Book_Master
select * from Book_Transaction
select * from Student_master
select M.Book_Code,M.Book_name,T.Stud_Code,T.Issue_Date,T.Exp_Return_date
from Book_Master M join
Book_Transaction T
on M.Book_code=T.Book_Code
select M.Book_Code,M.Book_name,S.Stud_Name,T.Issue_Date,T.Exp_Return_date
from Book_Master M join
Book_Transaction T
on M.Book_code=T.Book_Code
join Student_Master S
on T.Stud_code=S.Stud_Code