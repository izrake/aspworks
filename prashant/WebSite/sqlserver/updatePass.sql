create proc updateData @U_UserId varchar(30),@U_Password varchar(30),@U_NewPass varchar(30)
as
begin
if(exists(select * from UserRegistration where U_UserId=@U_UserId and U_Password=@U_Password)) 
update UserRegistration set U_Password=@U_NewPass where U_UserId=@U_UserId
else
print 'User Does not exist'
end

select * from UserRegistration;

delete UserRegistration where U_UserId='arun';

drop procedure updateData;