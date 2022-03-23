--The at begining
SELECT title, price
FROM pubs.dbo.titles
WHERE title LIKE 'The%'
--The inbetween the tile
SELECT title, price
FROM pubs.dbo.titles
WHERE title LIKE '%The%'
--title ends with e
SELECT title, price
FROM pubs.dbo.titles
WHERE title LIKE '%e'