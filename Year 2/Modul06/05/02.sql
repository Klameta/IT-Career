USE soft_uni;

-- lab 01
SELECT first_name, last_name, t.`name` AS `town`, address_text
FROM employees AS e
INNER JOIN addresses AS a
	ON e.address_id = a.address_id
INNER JOIN towns AS t
	ON a.town_id = t.town_id
ORDER BY first_name ASC,
		last_name ASC
LIMIT 5

-- lab 02
SELECT employee_id, first_name, `name` AS department_name
FROM employees AS e
JOIN departments AS d
	ON 
	
	
-- lab 03
SELECT first_name, last_name, hire_date, `name`
FROM employees AS e
INNER JOIN departments AS d
	ON e.department_id = d.department_id
	AND DATE(hire_date) > '1999/1/1'
	AND `name` IN ('Sales', 'Finance')
ORDER BY hire_date

-------------------------------------------------------------------------------------------

-- ex 01
SELECT first_name, last_name, t.`name` AS town, a.address_text
FROM employees AS e
JOIN addresses AS a 
	ON e.address_id = a.address_id
JOIN towns AS t
	ON a.town_id = t.town_id
ORDER BY first_name ASC,
			last_name ASC 
LIMIT 5

-- ex 02
SELECT first_name, last_name, hire_date, d.`name` AS	 dept_name
FROM employees AS e
JOIN departments AS d
	ON e.department_id = d.department_id
	AND DATE(hire_date) > '1999/1/1'
	AND d.`name` IN ('Sales', 'Finance')
ORDER BY hire_date ASC

-- ex 03
SELECT e.employee_id, first_name, p.`name` as project_name
FROM employees AS e
JOIN employees_projects AS ep
	ON e.employee_id = ep.employee_id
JOIN projects AS p
	ON ep.project_id = p.project_id
	AND DATE(p.start_date) > '2002/08/13'
	AND p.end_date IS  NULL
ORDER BY first_name ASC,
			`name` ASC
LIMIT 5

-- ex 04
USe soft_uni
SELECT e.employee_id,
		CONCAT(e.first_name," ", e.last_name) AS employee_name,
		CONCAT(m.first_name, " ", m.last_name) AS manager_name,
		d.`name` AS  department_name
FROM employees AS m
JOIN employees AS e
	ON m.employee_id = e.manager_id
	AND m.manager_id IS NOT null
JOIN departments AS d
	ON e.department_id = d.department_id
ORDER BY e.employee_id ASC 
LIMIT 5

-- ex 05
USE geography  

SELECT c.country_code, mountain_range, peak_name, elevation
FROM countries AS c
JOIN mountains_countries AS mc
	ON mc.country_code = c.country_code
	AND mc.country_code = 'BG' 
JOIN mountains AS m
	ON m.id = mc.mountain_id
JOIN peaks AS p
	ON p.mountain_id = mc.mountain_id
	AND elevation >2835
ORDER BY elevation DESC

-- ex 06
SELECT c.country_code, c.country_name, mountain_range
FROM countries AS c
JOIN mountains_countries AS mc
	ON mc.country_code = c.country_code
	AND mc.country_code IN ('BG', 'US', 'RU') 
JOIN mountains AS m
	ON m.id = mc.mountain_id
ORDER BY c.country_code ASC,
			m.mountain_range ASC
	


SELECT * FROM countries
SELECT * FROM mountains
SELECT * FROM mountains_countries
SELECT * FROM peaks













