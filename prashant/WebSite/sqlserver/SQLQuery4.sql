select * from PurchaseDetails;

select Order_Id,(select C_LName from CustomerDetails where C_FName='Prashant') from PurchaseDetails 
where C_Id=(select C_Id from CustomerDetails where C_FName='Prashant');


