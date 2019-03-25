select c.id, c.name from customers c 
where not exists (select l.id_customers from locations l where l.id_customers = c.id)