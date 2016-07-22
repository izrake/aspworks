create table ProductDetails(P_ID int identity(1,1)
constraint P_ID_Pk primary key,P_Name varchar(30) not null,
P_Description varchar(30) not null,P_Quantity smallint not null
);

insert into ProductDetails(P_Name,P_Description,P_Quantity)
values ('Puma','The brand in the market',5);
insert into ProductDetails(P_Name,P_Description,P_Quantity)
values ('Addidas','Won the best quality product',4);
insert into ProductDetails(P_Name,P_Description,P_Quantity)
values ('Converse','Cheap and the best',10);
insert into ProductDetails(P_Name,P_Description,P_Quantity)
values ('Mufti','best clothes',10);

insert into ProductDetails(P_Name,P_Description,P_Quantity,category)
values ('Mufti','best clothes',10,'clothes');

insert into ProductDetails(P_Name,P_Description,P_Quantity,category)
values ('Mufti','best clothes',10,'clothes');
select * from ProductDetails;

alter table ProductDetails add category varchar(30); 

select 

create table CustomerDetails(
C_ID int identity(1,1)
constraint C_ID_Pk primary key,
C_FName varchar(30) not null,C_LName varchar(30) not null,
C_Mobile int constraint chk_C_Mobile check (C_Mobile between 1000000000 and 9999999999),
C_Country varchar(16) constraint deft_C_Country default 'India',
C_Address varchar(40) not null,
C_PostalCode int not null
);

select * from CustomerDetails;

insert into CustomerDetails(C_FName,C_LName,C_Mobile,C_Address,C_PostalCode)
values('Prashant','Maurya',1044398969,'Porur,chennai',20522);

insert into CustomerDetails(C_FName,C_LName,C_Mobile,C_Address,C_PostalCode)
values('Ashutos','Sigh',1044398969,'Porur,chennai',20522);

insert into CustomerDetails(C_FName,C_LName,C_Mobile,C_Address,C_PostalCode)
values('Shreya','GuptA',1044398969,'Porur,chennai',20522);

insert into CustomerDetails(C_FName,C_LName,C_Mobile,C_Address,C_PostalCode)
values('Yuvraj','B',1044398969,'Porur,chennai',20522);

insert into CustomerDetails(C_FName,C_LName,C_Mobile,C_Address,C_PostalCode)
values('Aditya','Singh',1044398969,'Porur,chennai',20522);

select * from CustomerDetails;

create table PurchaseDetails(
Order_Id int identity(200,1)
constraint Order_ID_Pk primary key,
C_Id int
constraint C_ID_Fk references CustomerDetails(C_ID),
P_ID int 
constraint P_ID_fk references ProductDetails(P_ID),
O_Quantity smallint not null
);


insert into PurchaseDetails
(O_Quantity,C_Id,P_ID)
values
(2,5,2);
insert into PurchaseDetails(
C_Id,P_ID,O_Quantity)values
(
4,4,3
)
insert into PurchaseDetails(
C_Id,P_ID,O_Quantity)values
(
5,5,1
)
insert into PurchaseDetails(
C_Id,P_ID,O_Quantity)values
(
6,1,1
)
insert into PurchaseDetails(
C_Id,P_ID,O_Quantity)values
(
1,1,1
)

select * from ProductDetails;



select  c.C_FName,c.C_LName,P.Order_Id,P.P_ID,P.O_Quantity 
 from PurchaseDetails p,CustomerDetails c
 where P.C_Id=C.C_ID;
 