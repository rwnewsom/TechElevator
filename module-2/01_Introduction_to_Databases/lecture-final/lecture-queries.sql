-- SELECT ... FROM
SELECT * FROM country;

-- Selecting the names for all countries
SELECT name FROM country;


-- Selecting the name and population of all countries
SELECT population, name FROM country;

-- Selecting all columns from the city table
SELECT * FROM city;

-- SELECT ... FROM ... WHERE
-- Selecting the cities in Ohio
SELECT name, district, countrycode FROM city WHERE district = 'Ohio';

SELECT
	name,
	district,
	countrycode
FROM
	city
WHERE
	district = 'Ohio';


-- Selecting countries that gained independence in the year 1776
SELECT
	name,
	indepyear
FROM
	country
WHERE
	indepyear = 1776;


-- Selecting countries not in Asia
SELECT
	name,
	continent
FROM
	country
WHERE
	continent <> 'Asia'; -- <> is the same as != in C#

-- Selecting countries that do not have an independence year
SELECT
	name
FROM
	country
WHERE
	indepyear IS NULL

-- Selecting countries that do have an independence year
SELECT
	name
FROM
	country
WHERE
	indepyear IS NOT NULL


-- Selecting countries that have a population greater than 5 million
SELECT
	name
FROM
	country
WHERE
	population > 5000000



-- SELECT ... FROM ... WHERE ... AND/OR
-- Selecting cities in Ohio and Population greater than 400,000

SELECT
	name,
	district,
	population
FROM
	city
WHERE
	district = 'Ohio'
	AND population > 400000

-- Selecting country names on the continent North America or South America

SELECT
	name
FROM
	country
WHERE
	continent = 'North America'
	OR continent = 'South America'

SELECT
	name
FROM
	country
WHERE
	continent NOT IN ('North America', 'South America', 'Antarctica')



-- SELECTING DATA w/arithmetic
-- Selecting the population, life expectancy, and population per area
SELECT
	name as 'Country Name',
	population,
	lifeexpectancy,
	surfacearea,
	(population / surfacearea) as 'Density'
FROM
	country

--	note the use of the 'as' keyword



