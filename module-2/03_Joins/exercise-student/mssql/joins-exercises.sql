-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
SELECT
	f.title AS 'Films Starring Nick Stallone'
FROM
	film f
	INNER JOIN film_actor fa ON f.film_id = fa.film_id
	INNER JOIN actor a ON fa.actor_id = a.actor_id
WHERE
	a.first_name = 'Nick' AND a.last_name = 'Stallone'


-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)
SELECT
	f.title AS 'Films starring Rita Reynolds'
FROM film f
	INNER JOIN film_actor fa ON f.film_id = fa.film_id
	INNER JOIN actor a ON fa.actor_id = a.actor_id
WHERE
	a.first_name = 'Rita'
	AND a.last_name = 'Reynolds'

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
SELECT
	f.title
FROM
	film f
	INNER JOIN film_actor fa ON f.film_id = fa.film_id
	INNER JOIN actor a ON a.actor_id = fa.actor_id
WHERE
	--a.actor_id IN (35, 143)
	a.actor_id IN (SELECT actor_id FROM actor WHERE (last_name = 'DEAN' AND first_name = 'JUDY') OR (last_name = 'DEAN' AND first_name = 'RIVER'))
--SELECT * FROM actor WHERE last_name = 'Dean;

-- 4. All of the the ‘Documentary’ films
-- (68 rows)
SELECT
	f.title
FROM
	film f
	INNER JOIN film_category fc ON f.film_id = fc.film_id
	INNER JOIN category c ON fc.category_id = c.category_id
WHERE
	c.name = 'Documentary'

-- 5. All of the ‘Comedy’ films
-- (58 rows)
SELECT
	f.title
FROM
	film f
	INNER JOIN film_category fc ON f.film_id = fc.film_id
	INNER JOIN category c ON fc.category_id = c.category_id
WHERE
	c.name = 'Comedy'

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)
SELECT
	f.title
FROM
	film f
	INNER JOIN film_category fc ON f.film_id = fc.film_id
	INNER JOIN category c ON fc.category_id = c.category_id
WHERE
	c.name = 'Children'
	AND f.rating = 'G'

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
SELECT
	f.title
FROM
	film f
	INNER JOIN film_category fc ON f.film_id = fc.film_id
	INNER JOIN category c ON fc.category_id = c.category_id
WHERE
	c.name = 'Family'
	AND f.rating = 'G'
	AND f.length <120

-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)

-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)

-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)

-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)

-- 13. The first and last name of the top ten customers ranked by number of rentals
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)

-- 14. The first and last name of the top ten customers ranked by dollars spent
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)

-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.
-- (NOTE: Keep in mind that while a customer has only one primary store, they may rent from either store.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)

-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)

-- 17. The top five film categories by number of rentals
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)

-- 18. The top five Action film titles by number of rentals
-- (#1 should have 30 rentals and #5 should have 28 rentals)

-- 19. The top 10 actors ranked by number of rentals of films starring that actor
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)
-- HINT: There's something special about Susan Davis
--use subway map!

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor
-- (#1 should have 87 rentals and #5 should have 72 rentals)
-- HINT: your query should involve film, inventory, rental, film_actor, actor, film_category, and category. If your totals don't match, try changing how you join between these tables
--many ways to accomplish, join multiple tables, only one true path