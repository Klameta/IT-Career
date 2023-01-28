-- ex 01
SELECT e.employee_id, first_name,
		case
		when p.start_date >= '2005-01-01' then null
		ELSE p.`name`
		END AS `project_name`
FROM employees AS e
JOIN employees_projects AS ep
	ON ep.employee_id = e.employee_id
JOIN projects AS p
	ON p.project_id = ep.project_id
WHERE e.employee_id = 24
ORDER BY project_name ASC 

-- ex 02
USE geography

SELECT c1.continent_name AS 'FROM',
		c2.continent_name AS 'TO'
FROM continents AS c1
JOIN continents AS c2
ORDER BY c1.continent_name ASC,
			c2.continent_name ASC	

-- ex 03





SELECT * FROM continents