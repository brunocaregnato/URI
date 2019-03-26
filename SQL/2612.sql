select m.id,m.name from movies m, actors a, genres g,movies_actors ma
where m.id_genres = g.id and ma.id_movies = m.id and ma.id_actors = a.id
and g.description = 'Action' and a.name like '%Silva'