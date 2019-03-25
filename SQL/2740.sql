(select 'Podium: ' || l.team as name 
  FROM league l
  limit 3)
union all
(select * from (
  select 'Demoted: ' || team as name
    FROM league 
    order by position desc
    limit 2
    ) demoted
 order by 1);