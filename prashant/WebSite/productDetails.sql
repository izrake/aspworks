create table Product(P_PID varchar(20) constraint pk_PID primary key,ProductName varchar(40) 
not null,Category varchar(40) not null, SubCategory varchar(40) not null,P_Description varchar
(80),Price Money,Qty Integer,ProductImage varbinary(max),ProductDate datetime 
  )
  drop table Product
  create proc insertProductDetails @P_PID varchar(20),@ProductName varchar(40),@Category varchar(40)
  ,@SubCategory varchar(40),@Description varchar(80),@Price Money,@Qty integer,
  @ProductImage varbinary(max),@ProductDate datetime
  as
  begin
  if @ProductImage=''
  begin
  insert into Product(P_PID,ProductName,Category,SubCategory,P_Description,Price,Qty,ProductDate
  )
  values
  (
  @P_PID,@ProductName,@Category,@SubCategory,@Description,@Price,@Qty,@ProductDate
  )
  end
  else
  begin
   insert into Product(P_PID,ProductName,Category,SubCategory,P_Description,Price,Qty,
   ProductImage
   ,ProductDate
  )
  values
  (
  @P_PID,@ProductName,@Category,@SubCategory,@Description,@Price,@Qty, @ProductImage,@ProductDate
  )
  end
  end 
  
  sp_help Product