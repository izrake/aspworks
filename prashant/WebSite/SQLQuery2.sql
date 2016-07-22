

create procedure pcname
as
 
 begin
 select *from emp
 end
 go
 
  exec pcname
  
 create procedure pcname5 @paraminempname varchar(20)
 as
 begin
 

 select *from emp where empname like
'%a'
end
 go

 exec pcname5 'a'
 
alter table emp

add salary  int   
select * from emp

update emp set salary=10000 where empid=111

update emp set salary=1000 where empid=112
update emp set salary=20000 where empid=113
update emp set salary=10001 where empid=114


create procedure who @paraminempid int,@paramindepid int,@paramoutupsal int out ,@paramoutempname varchar(20)out
as
begin
select * from emp where empid=@paraminempid
update emp set salary = salary +10 where empid=@paraminempid

select * from emp where empid=@paraminempid

set @paramoutupsal = (select salary from emp where empid=@paraminempid)
set @paramoutempname = (select empname from emp where empid=@paraminempid )

--declare @outputvar1 int, @outputvar2 varchar(20)

end
go

declare @outputvar1 int, @outputvar2 varchar(20)

exec who 113,21,@outputvar1 out,@outputvar2 out

print 'salary of'+@outputvar2+'is'+cast(@outputvar1 as varchar(20))



