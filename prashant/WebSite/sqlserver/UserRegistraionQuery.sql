create table UserRegistration
(U_FName varchar(30) not null,U_LName varchar(30) not null, U_Gender char constraint 
chk_Gender check(U_Gender in ('M','F','O')) not null,
U_UserId varchar(30) constraint pk_UserId primary key,U_Password varchar(20) not null,
U_Country varchar(20) constraint df_Country default 'India',
U_Mobile varchar(11) constraint chk_UMobile check(U_Mobile between 7000000000 and 9999999999),
U_EmailId varchar(30) constraint nt_UEmaildId not null 
);

insert into UserRegistration(U_FName,U_LName,U_Gender,U_UserId,U_Password,U_Mobile,
U_EmailId)
values
('Prashant','Maurya','M','Izrake','1305Maths','9044398969','er.mauryaprashant@gmail.com');

select * from UserRegistration;


