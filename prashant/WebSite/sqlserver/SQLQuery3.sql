select * from ProductDetails;

insert into ProductDetails(P_Name,P_Description,P_Quantity,category)
values
('Wrangler','Blue Denim',10,'Jeans');

insert into ProductDetails(P_Name,P_Description,P_Quantity,category)
values
('JP','Blue Denim',1,'Jeans'),
('Tommy','Blue Shirt',20,'Shirts'),
('Tommy','Blue Jeans',20,'Trouser'),
('Tommy','Blue Trouser',20,'Jeans');



select AVG(P_Quantity) from ProductDetails
group by P_Quantity;

select c.C_Address,c.C_FName,c.C_LName,(select SUM(p.O_Quantity) from PurchaseDetails p
where p.C_Id=3  ) "Total Quantity" 
from CustomerDetails c
where c.C_ID=3;

select c.C_ID, c.C_FName,p.P_Name,O.O_Quantity from CustomerDetails c,ProductDetails p,PurchaseDetails o
where ( c.C_ID=o.C_Id and o.P_ID=p.P_ID);

select SUM(p.O_Quantity ) from PurchaseDetails p where p.C_Id=3 group by p.C_Id having p.C_Id=3;

select SUM(p.O_Quantity ) from PurchaseDetails p where p.C_Id=3;
select p.P_ID from PurchaseDetails p where p.C_Id=3;
