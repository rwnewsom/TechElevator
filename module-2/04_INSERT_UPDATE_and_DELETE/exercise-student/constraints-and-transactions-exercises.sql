-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
INSERT INTO actor (first_name, last_name)
VALUES('Hampton', 'Avenue')  --201

INSERT INTO actor (first_name, last_name)
VALUES('Lisa', 'Byway')	--202

--SELECT * FROM actor ORDER BY last_name

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.
--SELECT * FROM language

INSERT INTO film (title, description, release_year, language_id, length)
VALUES ('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in ancient Greece', 2008, 1, 198)

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
--Film ID 1001
--SELECT * FROM film ORDER BY title
INSERT INTO film_actor (actor_id, film_id)
VALUES (201, 1001)
INSERT INTO film_actor (actor_id, film_id)
VALUES (202, 1001)

-- 4. Add Mathmagical to the category table.
SELECT * FROM category --original 16 - new=17
INSERT INTO category (name)
VALUES ('Mathmagical')

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
--KM is 494, original cat is horror
--SELECT * FROM film WHERE title IN ('Euclidean PI', 'EGG IGBY', 'KARATE MOON', 'RANDOM GO', 'YOUNG LANGUAGE')--film_category --WHERE film_id = 494
-- WHERE film_id IN (274,494,714,996,1001,1002)
--SELECT * FROM category
BEGIN TRANSACTION

UPDATE
	film_category
SET
	category_id = 17
WHERE film_id IN (274,494,714,996,1001)


COMMIT TRANSACTION

--SELECT 
	--title, name 
--FROM 
	--film f
	--INNER JOIN film_category fc ON f.film_id = fc.film_id
	--INNER JOIN category c ON fc.category_id = c.category_id 
SELECT * FROM film

--BEGIN TRANSACTION
--DELETE FROM film WHERE film_id IN (1002,1003,1004)
--COMMIT TRANSACTION

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)
BEGIN TRANSACTION
UPDATE
	film
SET
	rating = 'G'
WHERE film_id IN (274,494,714,996,1001)
COMMIT TRANSACTION


-- 7. Add a copy of "Euclidean PI" to all the stores.
BEGIN TRANSACTION
--SELECT * FROM film --filmid 1001
--SELECT * FROM store --1 & 2
INSERT INTO inventory (store_id, film_id) VALUES(1,1001)
INSERT INTO inventory (store_id, film_id) VALUES(2,1001)
COMMIT TRANSACTION

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
BEGIN TRANSACTION
DELETE FROM film WHERE title = 'Euclidean PI'
ROLLBACK TRANSACTION
-- <YOUR ANSWER HERE No due to database conflicts - some actors reference the film, in addition to store inventory>


-- 9. Delete Mathmagical from the category table.
--SELECT * FROM category
BEGIN TRANSACTION
DELETE FROM category WHERE category_id =17
ROLLBACK TRANSACTION
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE -No due to referential integrity - film category points to it>

-- 10. Delete all links to Mathmagical in the film_category tale.
--SELECT * FROM film_category WHERE category_id = 17
BEGIN TRANSACTION
DELETE FROM film_category WHERE category_id = 17
COMMIT TRANSACTION

-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE YES as it involved a JOIN table.  FOr instance, Euclidean PI wasn't affected as it had no entry there.>

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
BEGIN TRANSACTION
DELETE FROM	category WHERE name = 'Mathmagical'
COMMIT TRANSACTION
--SELECT * FROM category

BEGIN TRANSACTION
DELETE FROM
	film
WHERE title = 'Euclidean PI'
ROLLBACK TRANSACTION
-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE I successfully deleted category as the action violated no constraints.  However deleting the film failed as two actors reference it.>

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.

--film ID has 'Allow Nulls' set to FALSE - neccesary as it is a primary key.  In order to delete the film, you would need to essentially reverse all transactions.
--remove it from the inventory of stores 1 & 2, and remove the actors who reference it. After that it could be deleted.
