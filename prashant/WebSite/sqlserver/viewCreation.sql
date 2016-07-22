create view vwUserRegistration
with encryption
as
select u.U_FName,u.U_LName,U.U_Gender from UserRegistration u

select * from vwUserRegistration

alter view vwUserRegistration 
with schemabinding
as
select u.U_FName,u.U_LName,U.U_Gender from dbo.UserRegistration u







