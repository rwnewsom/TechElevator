-- INSERT

-- 1. Add Klingon as a spoken language in the USA
INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('USA', 'Klingon', 0, 42)

SELECT * FROM countrylanguage WHERE countrycode = 'USA'

INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('USA', 'Belter', 0, 0.1) 

-- 2. Add Klingon as a spoken language in Great Britain (GBR)
INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('GBR', 'Klingon', 0, 0.7)

SELECT * FROM countrylanguage WHERE language IN ('Klingon', 'Belter')

-- UPDATE

-- 1. Update the capital of the USA to Columbus (3807)
SELECT
	id,
	district
FROM
	city
WHERE
	name = 'Columbus'


SELECT 
	ci.name,
	ci.district,
	ci.id
FROM
	country ct
	INNER JOIN city ci ON ci.id = ct.capital
WHERE
	ct.code = 'USA'

UPDATE
	country
SET
	capital = 3807 --Columbus, OH
WHERE
	code = 'USA'  --caution - where set before running

	SELECT * FROM city WHERE name='Washington' --id 3813

-- 2. Update the capital of the USA to Washington DC and the head of state
UPDATE
	country
SET
	capital = 3813,
	headofstate = 'Spongebob Squarepants'
WHERE
	code = 'USA'

-- 3. Try updating all of the cities to be in the USA and roll it back
BEGIN TRANSACTION

UPDATE
	country
SET
	headofstate = 'Donald Duck'
WHERE
	code = 'SAU'

SELECT * from country WHERE code = 'SAU'


--COMMIT TRANSACTION

ROLLBACK TRANSACTION

SELECT * from country

-- DELETE

-- 1. Delete English as a spoken language in the USA
BEGIN TRANSACTION

DELETE FROM countrylanguage WHERE countrycode = 'USA' AND language = 'English'

--ROLLBACK TRANSACTION
COMMIT TRANSACTION

-- 2. Delete all occurrences of the Klingon language 
BEGIN TRANSACTION

DELETE FROM countrylanguage WHERE language = 'Klingon'

COMMIT TRANSACTION

-- 3. Try deleting all of the rows from the country language table and roll it back.

-- REFERENTIAL INTEGRITY

-- 1. Try just adding Elvish to the country language table.
INSERT INTO countrylanguage (language)
VALUES ('Elvish') --not allowed

-- 2. Try inserting English as a spoken language in the country ZZZ. What happens?
INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES('ZZZ', 'English', 1, 100) --doesn't work

-- 3. Try deleting the country USA. What happens?
DELETE FROM country WHERE code = 'USA' --won't work due to city reference, language table pointing etc

BEGIN TRANSACTION

ROLLBACK TRANSACTION

-- CONSTRAINTS

-- 1. Try inserting English as a spoken language in the USA

-- 2. Try again. What happens?

-- 3. Let's relocate the USA to the continent - 'Outer Space'
BEGIN TRANSACTION

UPDATE
	country
SET
	--continent = 'Outer Space' --violates constraint
	continent = 'Antarctica'
WHERE
	code = 'USA'

ROLLBACK TRANSACTION

-- How to view all of the constraints
--easier to use the object explorer

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS

-- Demonstrate two different SQL connections trying to access the same table where one happens to be inside of a transaction but hasn't committed yet.
--if transaction not commited or rolled back, remains open and will 'grind' until committed/RB
BEGIN TRANSACTION

UPDATE
	country
SET
	headofstate = 'Spongebob Squarepants'

ROLLBACK TRANSACTION