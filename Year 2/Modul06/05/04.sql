-- ex 01
SELECT e.employee_id, first_name, last_name,
case 
	when p.start_date >= '2005-01-01' THEN NULL
 ELSE p.name
END as 'project_name'
FROM employees AS e
JOIN employees_projects AS ep
	ON e.employee_id = ep.employee_id
JOIN projects AS p
	ON ep.project_id = p.project_id
	WHERE e.employee_id = 24
ORDER BY project_name


-- ex 02
USE geography
SELECT c.continent_name AS "FROM", c1.continent_name AS "TO"
FROM continents AS c
JOIN continents AS c1
ORDER BY c.continent_name,
			c1.continent_name

-- ex 03

select
SELECT * FROM continents
