



create procedure UpdateCust1
as
	begin
	select * from CustomerDetails;
	delete CustomerDetails where C_ID=12;
	update CustomerDetails set C_PostalCode=221306 where C_ID=3;
	select p.Order_Id,p.P_ID,pr.P_Name,pr.P_Quantity
	 from PurchaseDetails p inner join ProductDetails pr ON
	 p.P_ID=pr.P_ID; 	
	end
go

exec UpdateCust1;


select p.Order_Id,p.P_ID,pr.P_Name,pr.P_Quantity,p.O_Quantity,(pr.P_Quantity-p.O_Quantity)"Prodcuct Remain"
	 from PurchaseDetails p inner join ProductDetails pr ON
	 p.P_ID=pr.P_ID; 	
	 
	 select * from ProductDetails;
	 
