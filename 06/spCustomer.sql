create proc spInsertCustomer @name nvarchar(40),@zipcode nvarchar(30),@email nvarchar(40),@username nvarchar(40),@password nvarchar(30)
as 
begin 
	declare @id int
    insert into customer(Name,Zipcode,Email)
    values (@name,@zipcode,@email);
	set @id = scope_identity();

	insert into login(CustomerId,username,password)
    values(@id,@username, @password);

end