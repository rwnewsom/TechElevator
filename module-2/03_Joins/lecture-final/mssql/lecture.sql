-- ********* INNER JOIN ***********

-- Let's find out who made payment 16666:
SELECT
	*
FROM
	payment
WHERE
	payment_id = 16666

-- Ok, that gives us a customer_id, but not the name. We can use the customer_id to get the name FROM the customer table
SELECT
	*
FROM
	customer
WHERE
	customer_id = 204

SELECT
	pay.amount,
	c.first_name,
	c.last_name
FROM
	payment pay
	INNER JOIN customer c ON pay.customer_id = c.customer_id
WHERE
	pay.payment_id = 16666

-- We just want everything from payment and then the first and last name of the customer:
SELECT
	p.*,
	c.first_name,
	c.last_name
FROM
	payment p
	INNER JOIN customer c ON p.customer_id = c.customer_id

-- But when did they return the rental? Where would that data come from? From the rental table, so let’s join that.
SELECT
	p.amount,
	c.first_name,
	c.last_name,
	r.return_date
FROM
	payment p
	INNER JOIN customer c ON c.customer_id = p.customer_id
	INNER JOIN rental r ON p.rental_id = r.rental_id

-- What did they rent? Film id can be gotten through inventory.
SELECT
	p.amount,
	c.first_name,
	c.last_name,
	r.return_date,
	i.film_id,
	f.title
FROM
	payment p
	INNER JOIN customer c ON c.customer_id = p.customer_id
	INNER JOIN rental r ON p.rental_id = r.rental_id
	INNER JOIN inventory i ON i.inventory_id = r.inventory_id
	INNER JOIN film f ON f.film_id = i.film_id

-- What if we wanted to know who acted in that film?
SELECT
	p.amount,
	c.first_name AS 'Renter First',
	c.last_name AS 'Renter Last',
	c.first_name + ' ' + c.last_name AS 'Renter',
	r.return_date,
	i.film_id,
	f.title,
	a.first_name AS 'Actor First',
	a.last_name AS 'Actor Last',
	a.first_name + ' ' + a.last_name AS 'Actor'
FROM
	payment p
	INNER JOIN customer c ON c.customer_id = p.customer_id
	INNER JOIN rental r ON p.rental_id = r.rental_id
	INNER JOIN inventory i ON i.inventory_id = r.inventory_id
	INNER JOIN film f ON f.film_id = i.film_id
	INNER JOIN film_actor fa ON fa.film_id = f.film_id
	INNER JOIN actor a ON a.actor_id = fa.actor_id

-- What if we wanted a list of all the films and their categories ordered by film title
SELECT
	f.title,
	f.description,
	f.rating,
	c.name
FROM
	film f
	INNER JOIN film_category fc ON fc.film_id = f.film_id
	INNER JOIN category c ON c.category_id = fc.category_id
ORDER BY f.title, c.name

-- Trying to find films with > 1 category record (no luck)
SELECT
	film_id,
	COUNT(film_id)
FROM
	film_category
GROUP BY film_id
ORDER BY film_id DESC

-- Show all the 'Comedy' films ordered by film title
SELECT
	f.title,
	f.description,
	f.rating,
	c.name
FROM
	film f
	INNER JOIN film_category fc ON fc.film_id = f.film_id
	INNER JOIN category c ON c.category_id = fc.category_id
WHERE c.name = 'Comedy'
ORDER BY f.title, c.name

SELECT
	f.title,
	c.name
FROM
	category c
	INNER JOIN film_category fc ON fc.category_id = c.category_id
	INNER JOIN film f ON f.film_id = fc.film_id
WHERE
	c.name = 'Comedy'

-- Finally, let's count the number of films under each category
SELECT
	c.name,
	COUNT(fc.film_id)
FROM
	category c
	INNER JOIN film_category fc ON c.category_id = fc.category_id
GROUP BY c.name
ORDER BY c.name

-- ********* LEFT JOIN ***********

-- (There aren't any great examples of left joins in the "dvdstore" database, so the following queries are for the "world" database)

-- A Left join, selects all records from the "left" table and matches them with records from the "right" table if a matching record exists.

-- Let's display a list of all countries and their capitals, if they have some.
SELECT
	ct.name AS 'Country Name',
	ct.capital,
	ci.name AS 'Capital City',
	ci.*
FROM
	country ct
	LEFT OUTER JOIN city ci ON ci.id = ct.capital

-- Only 232 rows
-- But we’re missing entries:

-- There are 239 countries. So how do we show them all even if they don’t have a capital?
-- That’s because if the rows don’t exist in both tables, we won’t show any information for it. If we want to show data FROM the left side table everytime, we can use a different join:

-- *********** UNION *************

-- Back to the "dvdstore" database...

-- Gathers a list of all first names used by actors and customers
-- By default removes duplicates
SELECT DISTINCT
	first_name
FROM
	customer

UNION

SELECT DISTINCT
	first_name
FROM
	actor

UNION

SELECT DISTINCT
	first_name --, username, password
FROM
	staff

-- Gather the list, but this time note the source table with 'A' for actor and 'C' for customer

SELECT DISTINCT
	first_name,
	'C' AS 'Type'
FROM
	customer

UNION

SELECT DISTINCT
	first_name,
	'A' AS 'Type of Entity'
FROM
	actor

UNION

SELECT DISTINCT
	first_name,
	'S'
FROM
	staff

-- ******** MOAR PRACTICE ********

-- Display all the films and their language
SELECT
	f.title,
	l.name
FROM
	film f
	INNER JOIN language l ON l.language_id = f.original_language_id

-- Display all the films and in English
SELECT
	f.title,
	l.name
FROM
	film f
	INNER JOIN language l ON l.language_id = f.language_id
WHERE 
	l.name = 'English'

-- Display all the films with their category

-- Display all the films with a category of Horror

-- Display all the films with a category of Horror and title that begins with the letter F

-- Who acted in what together?
SELECT
	a.actor_id,
	a.first_name,
	a.last_name,
	f.title,
	f.film_id
FROM
	actor a
	INNER JOIN film_actor fa ON a.actor_id = fa.actor_id
	INNER JOIN film f ON f.film_id = fa.film_id
WHERE
	a.actor_id = 110
ORDER BY f.title, a.first_name, a.last_name


-- How many times have two actors appeared together?

-- What movies did the two most often acted together actors appear in together?
