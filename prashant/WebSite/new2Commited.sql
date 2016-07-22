create table Product( Id INT NOT NULL IDENTITY(1,1),
                ProductId AS 'PR' + RIGHT('000'+ CONVERT(VARCHAR(4),Id),4) PERSISTED constraint
                 ckpid Primary Key
                ,ProductName varchar(40) 
not null,Category varchar(40) not null, SubCategory varchar(40) not null,P_Description varchar
(80),Price Money,Qty Integer,ProductImage varbinary(max),
ProductDate datetime not null default SYSDATETIME()
  )
  drop table Product;
  
  drop proc insertProductDetails
  
   create proc insertProductDetails @ProductName varchar(40),@Category varchar(40)
  ,@SubCategory varchar(40),@Description varchar(80),@Price Money,@Qty integer,@ImageValue varbinary(max)
  as
  begin
   insert into Product(ProductName,Category,SubCategory,P_Description,Price,Qty
  )
  values
  (
 @ProductName,@Category,@SubCategory,@Description,@Price,@Qty
  )
  end
  
  select * from Product;
  
  
  Id INT NOT NULL IDENTITY(1,1),
    
  ProductId AS 'PR' + RIGHT('000'+ CONVERT(VARCHAR(4),Id),4) PERSISTED constraint ckpid Primary Key
                
  insert into Product(ProductName,Category,SubCategory,P_Description,Price,Qty
  )
  values
  (
'Puma','Men','Shoe','Excellentproduct','900','5'
  )