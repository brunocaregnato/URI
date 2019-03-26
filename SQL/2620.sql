select c.name,d.id from customers c, orders d where c.id = d.id_customers
and d.orders_date between '2016-01-01' and '2016-06-30'