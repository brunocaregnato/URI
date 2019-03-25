select s.name from providers p, products s where p.id = s.id_providers
and s.amount between 10 and 20 and p.name like 'P%'