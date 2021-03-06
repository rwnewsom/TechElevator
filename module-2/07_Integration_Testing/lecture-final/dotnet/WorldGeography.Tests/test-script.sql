-- Delete all of the data
DELETE FROM countrylanguage;
UPDATE country SET capital = NULL;
DELETE FROM city;
DELETE FROM country;

-- Insert a fake country
INSERT INTO country VALUES ('USA', 'United States of America', 'North America', 'Region', 100, null, 100, null, null, null, 'United States of America', 'Under AI Control', 'HAL-9000', null, 'US');

-- Insert a fake city
INSERT INTO city VALUES ('Flavortown', 'USA', 'Ohio', 1);
DECLARE @newCityId int = (SELECT @@IDENTITY);

-- Insert a fake country language
INSERT INTO countrylanguage VALUES ('USA', 'C#', 1, 100);

-- Assign the fake city to be the capital of the fake country
UPDATE country SET capital = @newCityId;

-- Return the id of the fake city
SELECT @newCityId as newCityId;