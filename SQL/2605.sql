select p.name, s.name from products p join providers s on p.id_providers = s.id 
join categories c on p.id_categories = c.id 
where p.id_categories = 6