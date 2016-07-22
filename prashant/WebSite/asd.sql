select * from Product

create table ImageTest
(ID int identity(1,1) primary key,imageValue varbinary(max));

create proc imageUpload @imageValue varbinary(max)
as
begin
insert into ImageTest(imageValue)
values
(@imageValue);
end

select * from ImageTest;