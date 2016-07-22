select * from ProductDetails;
select * from CustomerDetails;
select * from PurchaseDetails;

select c.C_FName,c.C_LName,p.O_Quantity,p.P_ID from CustomerDetails c,PurchaseDetails p
where c.C_ID=p.C_Id;



