select l.name, round((l.omega*1.618),3) "Fator N"
    from life_registry l
    join dimensions d on l.dimensions_id = d.id
    where d.name in ('C875', 'C774')
    and l.name like 'Richar%'
    order by 2;