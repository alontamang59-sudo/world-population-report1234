SQL

SELECT Code,
       Name,
       Continent,
       Region,
       Population
FROM country
WHERE Continent = 'Asia'
ORDER BY Population DESC;
