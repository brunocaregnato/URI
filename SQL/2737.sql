select l.name, l.customers_number 
	from lawyers l
	where l.customers_number = ( select max(l.customers_number) from lawyers l)
	union all
select l.name, l.customers_number
	from lawyers l
	where l.customers_number = ( select min(l.customers_number) from lawyers l)
	union all
select 'Average', round(avg(l.customers_number),0) from lawyers l;