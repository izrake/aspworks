create procedure setTheValues  @U_FName varchar(30),@U_LName varchar(30),
@U_Gender char,@U_UserId varchar(30),@U_Password varchar(20),@U_Mobile varchar(11)
,@U_Country varchar(20),@U_EmailId varchar(30)
as 
begin
if @U_Country=''
begin
set @U_Country='India'
insert into UserRegistration(U_FName,U_LName,U_Gender,U_UserId,U_Password,U_Mobile
,U_Country,U_EmailId)
values
(@U_FName,@U_LName,@U_Gender,@U_UserId,@U_Password,@U_Mobile,@U_Country,@U_EmailId)
end
else
begin
insert into UserRegistration(U_FName,U_LName,U_Gender,U_UserId,U_Password,U_Mobile
,U_Country,U_EmailId)
values
(@U_FName,@U_LName,@U_Gender,@U_UserId,@U_Password,@U_Mobile,@U_Country,@U_EmailId)
end
end
go


declare @countryName varchar(30)=''
exec setTheValues 'Diya','Singh','F','diya','diya','9959885583',@countryName,'diya@gmail.com'



select * from UserRegistration;

update UserRegistration set U_Country='Britain',U_EmailId='ppsd@brexit.com' where U_UserId='raghu' 

