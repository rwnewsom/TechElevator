-- ORDERING RESULTS


-- Populations of all countries in descending order by population

SELECT
	name,
	population
FROM
	country
ORDER BY
	population DESC

--Names of countries and continents in ascending order by continent and then name

SELECT 
	name,
	continent
FROM
	country
ORDER BY
	continent ASC, --could omit ASC as defaults to ascending
	name ASC

-- LIMITING RESULTS
-- The name and average life expectancy of the countries with the 10 highest life expectancies.
SELECT TOP 10
	name,
	lifeexpectancy
FROM
	country
ORDER BY
	lifeexpectancy DESC


-- The 10 largest countries in the world (by surface area)
SELECT TOP 10
	name,
	surfacearea
FROM
	country
ORDER BY surfacearea DESC

-- CONCATENATING OUTPUTS

-- The name & state of all cities like "city, state", sorted by state then city
SELECT
	(name + ', ' + district) AS Address
FROM
	city
ORDER BY
	district, name

-- SUBQUERIES
SELECT
	name,
	countrycode
FROM
	city
WHERE
	countrycode IN (SELECT code FROM country WHERE name = 'China')
-- Find the names of cities under a given government leader

SELECT
	name
FROM
	city
WHERE
	countrycode IN (SELECT code FROM country WHERE headofstate = 'George W. Bush')
	--countrycode IN ('ASM', 'GUM', 'MNP', 'PRI', 'UMI', 'USA', 'VIR')

-- Find the names of cities whose country they belong to has not declared independence yet
SELECT
	name
FROM
	city
WHERE
	countrycode	IN (SELECT code FROM country WHERE indepyear IS NULL)
-- DISTINCT
-- Find the unique names of each continent
SELECT DISTINCT
	continent
FROM
	country
ORDER BY continent

-- Find the unique city names
SELECT DISTINCT --gives more results because unique pairs
	name
FROM
	city

-- AGGREGATE FUNCTIONS
-- AVG - Average Life Expectancy in the World
SELECT
	AVG(lifeexpectancy) AS 'Average Life Expectancy'
FROM
	country

-- SUM - Total population in Ohio
SELECT
	SUM(population) AS 'Total Population',
	AVG(population) AS 'Average Population'
FROM
	city
WHERE
	district = 'Ohio'

-- MIN - The surface area of the smallest country in the world
SELECT TOP 1
	surfacearea,
	name
FROM
	country
ORDER BY
	surfacearea ASC
--better way
SELECT
	MIN(surfacearea) AS 'Smallest Surface Area'
	--Can't add non-aggregate function: name
FROM
	country

-- MAX - The largest city in the world (in population)
SELECT
	--name, again, causes error - fyi Mumbai
	MAX(population) AS 'Largest Population'
FROM
	city

-- COUNT - Count the number of rows in the city table

SELECT
	COUNT(name) --could also just use *, odd a parameter is needed at all as just counting rows
FROM
	city

-- COUNT - The number of countries who declared independence in 1991

SELECT
	COUNT(1) --stupid and confusing but FASTER than * or other parameter
FROM
	country
WHERE
	indepyear = 1991


-- GROUP BY
-- Count the number of countries where each language is spoken, ordered from most countries to least
SELECT
language,
COUNT(language)
FROM 
	countrylanguage
GROUP BY language
ORDER BY COUNT(language) DESC

-- Average life expectancy of each continent ordered from highest to lowest
SELECT
	continent,
	AVG(lifeexpectancy) AS 'Average Life Expectancy',
	COUNT(1) AS 'Num of Countries in Continent'
FROM
	country
GROUP BY continent
ORDER BY AVG(lifeexpectancy) DESC

-- Exclude Antarctica from consideration for average life expectancy
SELECT
	continent,
	AVG(lifeexpectancy) AS 'AVG Life'
FROM
	country
WHERE continent <> 'Antarctica'
GROUP BY continent


-- Sum of the population of cities in each state in the USA ordered by state name
SELECT
	district AS 'State',
	SUM(population) AS 'Population',
	AVG(population) AS 'State Average City Population',
	COUNT(name) AS 'Cities in State'
	
FROM
	city
WHERE countrycode = 'USA'
GROUP BY district
ORDER BY district

-- The average population of cities in each state in the USA ordered by state name

--Explore Languages with Grouping
SELECT
	language,
	isofficial,
	COUNT(language) AS 'Num Occurances',
	AVG(percentage) AS 'Avg % of Population'
FROM
	countrylanguage
GROUP BY language, isofficial
ORDER BY COUNT(language) DESC
-- Additional samples

--Explore govenment types w grouping
SELECT
	governmentform,
	COUNT(governmentform) AS '# Instances',
	SUM(population) AS 'Total Population'
FROM
	country
GROUP BY governmentform
ORDER BY COUNT(governmentform) DESC

--explore aliasing
SELECT
	ct.name
From
	city ct

-- You may alias column and table names to be more descriptive

-- Alias can also be used to create shorthand references, such as "c" for city and "co" for country.

-- Ordering allows columns to be displayed in ascending order, or descending order (Look at Arlington)

-- Most database platforms provide string functions that can be useful for working with string data. In addition to string functions, string concatenation is also usually supported, which allows us to build complete sentences if necessary.

-- Gets the SUM of the population field in the city table, as well as
-- the AVG population, and a COUNT of the total number of rows.

-- Gets the MIN population and the MAX population from the city table.

-- Using a GROUP BY with aggregate functions allows us to summarize information for a specific column. For instance, we are able to determine the MIN and MAX population for each countrycode in the city table.

-- While you can use TOP to limit the number of results returned by a query,
-- in SQL Server it is recommended to use OFFSET and FETCH if you want to get
-- "pages" of results. For instance, to get the first 10 rows in the city table
-- ordered by the name, you could use the following query.
-- (Skip 0 rows, and return only the first 10 rows from the sorted result set.)

SELECT name, population
FROM city
ORDER BY name
OFFSET 40 ROWS FETCH NEXT 10 ROWS ONLY;
--update offset next or prev
