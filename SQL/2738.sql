select c.name, round((((s.math*2)+(s.specific*3)+(s.project_plan*5))/10),2) avg
	from score s join candidate c
    on c.id = s.candidate_id
    order by 2 desc
