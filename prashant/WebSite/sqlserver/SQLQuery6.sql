create procedure PassArg
@chanegVal varchar(30),@changeId int,@returnVal int out 
as
begin
set nocount on;
update CustomerDetails set C_FName=@chanegVal where C_ID=@changeId;
select p.P_ID from ProductDetails p;
end
go

declare @tp int  
exec PassArg 'Prashant',3,@tp out;

select  * from CustomerDetails;






