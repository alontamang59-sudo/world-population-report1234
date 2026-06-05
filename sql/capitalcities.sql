SELECT city.Name,
       country.Name,
       city.Population
FROM city
JOIN country ON city.CountryCode = country.Code
WHERE city.ID = country.Capital
ORDER BY city.Population DESC;