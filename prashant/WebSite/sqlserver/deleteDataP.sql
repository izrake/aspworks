create proc deleteUser @U_UserId varchar(30),@U_Pass varchar(30)
as 
begin
if(exists(select * from UserRegistration where U_UserId=@U_UserId and U_Password=@U_Pass))
delete UserRegistration where U_UserId=@U_UserId
end 
