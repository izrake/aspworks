create proc searchDetails @UserId varchar(30)
as
begin
if(exists(select * from UserRegistration where U_UserId=@UserId))
select U_Password from UserRegistration
else
print 'userid does not exist'
end
