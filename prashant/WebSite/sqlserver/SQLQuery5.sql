select * from ProductDetails;
select * from CustomerDetails;
select * from PurchaseDetails;

select SUM(P_Quantity),category from ProductDetails c
group by category;

select pr.C_ID,sum(pr.O_Quantity) "Total Quantity" from PurchaseDetails pr,CustomerDetails c
where c.C_ID=pr.C_Id
group by pr.C_Id;

select c.C_FName "Customer Name",p.[Total Quantity]  from CustomerDetails c, (select pr.C_ID,sum(pr.O_Quantity)
 "Total Quantity" from PurchaseDetails pr,CustomerDetails c
where c.C_ID=pr.C_Id
group by pr.C_Id) p
where p.C_Id=c.C_ID;

select * from CustomerDetails;

go
create function CustomerData()
returns varchar(30)
as 
begin
	declare @custname varchar(30)=(select c.C_FName from CustomerDetails c where c.C_ID=3);	
	return @custname;
end
go

declare @output varchar(30) ;
set @output=dbo.CustomerData();

select c.C_Address from CustomerDetails c
where c.C_FName=@output;


go
create function ReturnTable()
returns table
as
	return
	select * from CustomerDetails;
	
go

select * from ReturnTable();

go 
create function ReturnTableByTemp()
returns @TempCust table
(Cust_Id int ,Cust_Country varchar(30),Cust_LastName varchar(30))
as
begin 
insert into @TempCust select c.C_ID,C.C_Country,c.C_LName from CustomerDetails c
return
end
go

select * from ReturnTableByTemp() c where c.Cust_Id>6;

go 
create function ReturnTableByArg(@search varchar(30))
returns @tempTable table
(Cust_Id int,Cust_Name varchar(30),Cust_Address varchar(30))
as
begin
insert into @tempTable select c.C_ID,c.C_FName,c.C_Address  from CustomerDetails c
where c.C_LName=@search
return
end
go

select * from ReturnTableByArg('singh');

go
create function OrderSummary()
returns @QuantityTable table
(Cust_Id int,Cust_Name varchar(30),T_B_Quantity int )
as
begin
	insert into @QuantityTable select c.C_ID,C.C_FName,p.O_Quantity
	 from CustomerDetails c,PurchaseDetails p where c.C_ID=p.C_Id;
	 return;
end
go

select o.Cust_Id,sum(o.T_B_Quantity)  from OrderSummary() o
group by o.Cust_Id;

select * from OrderSummary()
