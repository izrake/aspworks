select * from CustomerDetails;
select * from ProductDetails;
select * from PurchaseDetails;

insert into PurchaseDetails(C_Id,P_ID,O_Quantity)
values
(3,5,2),
(3,1,6),
(6,1,4);

select  SUM(p.O_Quantity) "Total Quantity" from PurchaseDetails p
where p.C_Id=3;
