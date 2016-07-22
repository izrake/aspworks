
create table signin1
( FirstName varchar(20) constraint cnkFname1 not null,
 LastName varchar(20) constraint cnkLname1 null,
 Gender varchar(1) constraint cnkgender1 check(gender in ('F','M','O')),
 Username varchar(20) constraint cnkusername1 primary key,
 passwords varchar(20) constraint cnkpassword1 not null,
 country varchar(20) constraint cnkcountry1 default('INDIA'),
 mobilenumber varchar(10)constraint cnkmobile1 check((mobilenumber like '7%')or(mobilenumber like '8%')or(mobilenumber like '9%')),
 emailID varchar(20) constraint cnkemail1 unique);
 
 select * from signin1
 
 insert into signin(FirstName,LastName,Gender,Username,passwords,country,mobilenumber,emailID)values('bhavana','ghn','F','bhav','bhavana','FRANCE','9','gff@gmail.com')
  
  insert into signin1(FirstName,LastName,Gender,Username,passwords,country,mobilenumber,emailID)
  values('bhavana','ghn','F','bh','bha','FRANCE','9098765432','gff12@gmail.com')
  
    insert into signin1(FirstName,LastName,Gender,Username,passwords,mobilenumber,emailID)
  values('bhavana','ghn','o','bh634','bha','9098765432','gff12d543@gmail.com')
  
create table registration
( FirstName varchar(20) constraint cnkFname1 not null,
 LastName varchar(20) constraint cnkLname1 null,
 Gender varchar(1) constraint cnkgender1 check(gender in ('F','M','O')),
 Username varchar(20) constraint cnkusername1 primary key,
 passwords varchar(20) constraint cnkpassword1 not null,
 country varchar(20) constraint cnkcountry1 default('INDIA'),
 mobilenumber varchar(10)constraint cnkmobile1 check((mobilenumber like '7%')or(mobilenumber like '8%')or(mobilenumber like '9%')),
 emailID varchar(20) constraint cnkemail1 unique);
 
 drop table registration
   
create table registration
( FirstName varchar(20) constraint cnkFname1 not null,
 LastName varchar(20) constraint cnkLname1 null,
 Gender varchar(1) constraint cnkgender1 check(gender in ('F','M','O')),
 Username varchar(20) constraint cnkusername1 primary key,
 passwords varchar(20) constraint cnkpassword1 not null,
 country varchar(20) constraint cnkcountry1 default('INDIA'),
 mobilenumber varchar(10)constraint cnkmobile1 check((mobilenumber like '7%')or(mobilenumber like '8%')or(mobilenumber like '9%')),
 emailID varchar(20) constraint cnkemail1 unique);
 
create procedure pcreg1 @paramFirstName varchar(20), @paramLastName varchar(20), @paramGender varchar(20), @paramUsername varchar(20), @parampasswords varchar(20), @paramcountry varchar(20),@parammobilenumber varchar(20), @paramemailID varchar(20)
as
begin
select * from registration
insert into registration(FirstName,LastName,Gender,Username,passwords,country,mobilenumber,emailID)
  values(@paramFirstName,@paramLastName,@paramGender,@paramUsername,@parampasswords,@paramcountry,@parammobilenumber,@paramemailID)
 select * from registration
 --declare @output=
  end
  

  exec pcreg1 'bhavana','ghn','o','bh63334','bha33','GREEK','9098765432','gff123d543@gmail.com' 
  exec pcreg1 'bhavana','ghn','o','bh6334','bha33','GREEK','9098765432','gff12d543@gmail.com' 
  
  select * from empdetails
  select * from emp