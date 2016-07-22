create table OrderDetail(OrderId int identity(1,1) primary key,
ProductCode varchar(6) constraint fk_ProductId foreign key(ProductCode) references Product(ProductCode),
G_UserName  varchar(40) constraint fk_G_Username foreign key(G_UserName) references GmailSignUp(G_Username),
OrderDate datetime not null default SYSDATETIME(),Quantity int not null
)


create table Product( P_Id INT NOT NULL IDENTITY(1,1),
                ProductCode varchar(6) primary key
                ,ProductName varchar(40) 
not null,Category varchar(40) not null, SubCategory varchar(40) not null,P_Description varchar(80),Price Money,Qty Integer,ProductImage varbinary(max),
ProductDate datetime not null default SYSDATETIME(),PImage varbinary(max)
  )
  
  drop table Product;
  
  drop table OrderDetail;
  
  drop proc insertProductDetails
  
   create proc insertProductDetails @ProductCode varchar(6), @ProductName varchar(40),@Category varchar(40)
  ,@SubCategory varchar(40),@Description varchar(80),@Price Money,@Qty integer,@PImage varbinary(max)
  as
  begin
   insert into Product(ProductCode,ProductName,Category,SubCategory,P_Description,Price,Qty,PImage
  )
  values
  (
 @ProductCode,@ProductName,@Category,@SubCategory,@Description,@Price,@Qty,@PImage
  )
  end
  
  select * from Product;
  
  sp_help GmailSignUp;
  
  sp_help OrderDetail;
  
  select * from GmailSignUp;