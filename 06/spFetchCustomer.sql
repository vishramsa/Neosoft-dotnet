create proc fetchCustomer
as
begin
select c.Name,c.Zipcode,c.Email,l.username from customer as c join login as l on c.Id=l.CustomerId;
end
























