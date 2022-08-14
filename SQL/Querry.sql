select c.Name from Customers as c
left join Orders as o on o.CustomerId = c.Id
where o.CustomerId is null