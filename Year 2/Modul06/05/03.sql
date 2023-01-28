-- ex 01
SELECT country_name, river_name
FROM countries AS c
LEFT OUTER JOIN countries_rivers AS cr
	ON c.country_code = cr.country_code
LEFT OUTER JOIN rivers AS r
	ON cr.river_id = r.id
WHERE continent_code = 'AF'
ORDER BY country_name ASC

-- ex 02
SELECT country_name
FROM countries AS c
LEFT JOIN mountains_countries AS mc
	ON mc.country_code = c.country_code
WHERE mountain_id IS NULL

-- ex 03
SELECT mountain_range, peak_name, elevation
FROM mountains AS m
OUTER JOIN  mountains_countries AS mc
	ON m.id = mc.mountain_id
JOIN peaks AS p
	ON p.mountain_id = m.id

-- ex 04
SELECT e.employee_id, first_name, last_name
FROM employees AS e
LEFT JOIN employees_projects AS ep
	ON e.employee_id = ep.employee_id
	WHERE ep.project_id IS NULL 
ORDER BY first_name,
			last_name
LIMIT 3


SELECT * FROM employees
SELECT * FROM employees_projects