create procedure viewTheUserRegistration @userid varchar(30),@password varchar(30)
as
begin
if @userid='' and @password=''
begin
select * from UserRegistration
end
else
begin
select u.U_FName,u.U_LName,u.U_Gender,u.U_Mobile,u.U_EmailId,u.U_Country from UserRegistration u
where u.U_UserId=@userid and u.U_Password=@password
end
end

exec viewTheUserRegistration 'arun','sebestian'


