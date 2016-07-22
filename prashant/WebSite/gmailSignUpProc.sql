create table GmailSignUp
(
G_FName varchar(40) constraint nt_FName not null,G_LName varchar(40) constraint nt_LName not null,
G_UserName varchar(40) constraint pk_UserName primary key,G_Password varchar(40) 
constraint nt_Password not null,G_BirthDate Date not null,G_Gender char 
constraint nt_Gender not null,G_MobileNo varchar(10) constraint unq_MobileNo unique constraint 
chk_MobileNo check(G_MobileNo between 7000000000 
and 9999999999),G_AltEmail varchar(40) constraint unq_AltEmail unique,G_Location varchar(40) not 
null,G_UserImage varbinary(max)
)

create procedure GmailSignUpPro @G_FName varchar(40),@G_LName varchar(40),@G_Username varchar(40)
,@G_Password varchar(40),@G_BirthDate date,@G_Gender char,@G_MobileNo varchar(10),
@G_AltEmail varchar(40),@G_Location varchar(40),@G_UserImage varbinary(max)
as
begin
if @G_UserImage=''
begin
insert into GmailSignUp(G_FName,G_LName,G_UserName,G_Password,G_BirthDate,G_Gender,G_MobileNo
,G_AltEmail,G_Location)
values
(@G_FName,@G_LName,@G_Username,@G_Password,@G_BirthDate,@G_Gender,@G_MobileNo,@G_AltEmail,
@G_Location)
end
else
begin
insert into GmailSignUp(G_FName,G_LName,G_UserName,G_Password,G_BirthDate,G_Gender,G_MobileNo
,G_AltEmail,G_Location,G_UserImage)
values
(@G_FName,@G_LName,@G_Username,@G_Password,@G_BirthDate,@G_Gender,@G_MobileNo,@G_AltEmail,
@G_Location,@G_UserImage)
end
end
