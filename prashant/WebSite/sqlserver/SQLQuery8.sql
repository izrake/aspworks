declare @counter int ;
declare @month int ;
set @month=MONTH(GETDATE());
set @counter =1;
declare @mark int;
declare @grade varchar(30);
set @mark=50;
if @mark<=50
begin
set @grade='4th'
select 'Fail',@grade,@month;

end
else
begin
set @grade='First'
select 'Pass';
select @grade;
end


declare @count int;
set @count=1;
while (@count<10)
begin
	--select c.C_FName,C.C_FName  from CustomerDetails c 
	--where c.C_ID=@count;
	select c.C_ID, c.C_FName,c.C_LName from CustomerDetails c
	where c.C_ID=@count;
	set @count=@count+1;
end

declare @counte int;
declare @FName varchar(30),@LName varchar(30),@Mobile int, @Country varchar(30),
@Address varchar(30),@PostalCode int;
set @FName='Shrishti';
set @LName='Singh';
set @Mobile=1002354681;
set @Country='London';
set @Address='Bachingam Palace';
set @PostalCode=000125;
insert into CustomerDetails (C_FName,C_LName,C_Mobile,C_Country,C_Address,C_PostalCode)
values
(@FName,@LName,@Mobile,@Country,@Address,@PostalCode);

select * from CustomerDetails;


