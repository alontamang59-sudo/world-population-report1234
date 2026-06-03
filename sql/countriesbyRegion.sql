Java

SELECT Code,
       Name,
       Continent,
       Region,
       Population
FROM country
WHERE Region = 'Western Europe'
ORDER BY Population DESC;
