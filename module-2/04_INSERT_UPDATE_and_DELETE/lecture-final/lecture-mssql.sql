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

INSERT INTO countrylanguage (countrycode, language)
VALUES ('GBR', 'Belter')

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
	capital = 3807 -- Columbus, OH
WHERE
	code = 'USA'

--UPDATE
--	users
--SET
--	password = 'DefaultPasswordHash'

SELECT * FROM city WHERE name = 'Washington'

-- 2. Update the capital of the USA to Washington DC and the head of state

UPDATE
	country
SET
	capital = 3813, -- Washington D.C.
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

SELECT * FROM country WHERE code = 'SAU'

ROLLBACK TRANSACTION

-- Trying to change the Primary Key
BEGIN TRANSACTION

UPDATE
	country
SET
	code = 'ZZ4'
WHERE
	code = 'ATA'

ROLLBACK TRANSACTION

SELECT * FROM country WHERE name = 'Antarctica'

--ROLLBACK TRANSACTION

SELECT * from country

-- DELETE

-- 1. Delete English as a spoken language in the USA
BEGIN TRANSACTION

DELETE FROM countrylanguage WHERE countrycode = 'USA' AND language = 'English'

COMMIT TRANSACTION

-- 2. Delete all occurrences of the Klingon language
BEGIN TRANSACTION

DELETE FROM countrylanguage WHERE language = 'Klingon'

COMMIT TRANSACTION

-- 3. Try deleting all of the rows from the country language table and roll it back.

-- REFERENTIAL INTEGRITY

-- 1. Try just adding Elvish to the country language table.
INSERT INTO countrylanguage (language)
VALUES ('Elvish')

-- 2. Try inserting English as a spoken language in the country ZZZ. What happens?
INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('ZZZ', 'English', 1, 100)

INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('USA', 'English', 1, 100)

-- 3. Try deleting the country USA. What happens?
DELETE FROM country WHERE code = 'USA'

-- CONSTRAINTS

-- 1. Try inserting English as a spoken language in the USA

-- 2. Try again. What happens?

-- 3. Let's relocate the USA to the continent - 'Outer Space'
BEGIN TRANSACTION

UPDATE
	country
SET
	continent = 'Antarctica'
WHERE
	code = 'USA'

ROLLBACK TRANSACTION

-- How to view all of the constraints

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS

-- Demonstrate two different SQL connections trying to access the same table where one happens to be inside of a transaction but hasn't committed yet.

BEGIN TRANSACTION

UPDATE
	country
SET
	headofstate = 'Spongebob Squarepants'

COMMIT TRANSACTION

-- JOIN PRACTICE

USE dvdstore

SELECT
	s.store_id,
	a.address,
	a.district,
	a.postal_code,
	a.phone,
	c.city,
	ctry.country,
	mgr.first_name + ' ' + mgr.last_name AS 'Manager',
	w.first_name + ' ' + w.last_name AS 'Employee'
FROM
	staff w
	INNER JOIN store s ON w.store_id = s.store_id
	INNER JOIN address a ON s.address_id = a.address_id
	INNER JOIN city c ON a.city_id = c.city_id
	INNER JOIN country ctry ON ctry.country_id = c.country_id
	INNER JOIN staff mgr ON s.manager_staff_id = mgr.staff_id
	--INNER JOIN staff worker ON worker.address_id = a.address_id