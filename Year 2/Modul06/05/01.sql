USE geography

--lab 01
SELECT mountain_range, peak_name, elevation
FROM peaks AS p
JOIN mountains AS m 
	ON p.mountain_id = m.id
WHERE mountain_range = 'Rila'
ORDER BY elevation DESC 


--lab 02
SELECT mountain_range, peak_name, elevation
FROM peaks AS p
JOIN mountains AS m
	ON p.mountain_id = m.id
JOIN mountains_countries AS mc
	ON m.id = mc.mountain_id
WHERE country_code = 'BG'
ORDER BY elevation DESC 

--lab 03

SELECT country_name, mountain_range, peak_name, elevation
FROM peaks AS p
JOIN mountains AS m
	ON p.mountain_id = m.id
JOIN mountains_countries AS mc
	ON m.id = mc.mountain_id
JOIN countries AS c
	ON mc.country_code = c.country_code
ORDER BY elevation DESC 
--------------------------------------------------------------------------------------------
USE  soft_uni

--ex 01
SELECT employee_id, job_title, e.address_id, address_text
FROM employees AS e
JOIN addresses AS a
	ON e.address_id = a.address_id
ORDER BY e.address_id ASC	
LIMIT 5

--ex 02
SELECT employee_id, first_name, last_name, d.`name`
FROM employees AS e
JOIN departments AS d
	ON e.department_id = d.department_id
WHERE d.name = 'Sales'
ORDER BY employee_id DESC 

--ex 03
SELECT employee_id, first_name, salary, `name` AS department_name
FROM employees AS e
JOIN departments AS d
	ON e.department_id = d.department_id
WHERE e.salary >15000
ORDER BY e.department_id DESC,
			salary desc
LIMIT 5

--ex 04
SELECT e.employee_id, first_name
FROM employees AS e
WHERE e.employee_id <> ANY ( 
								SELECT employee_id
								FROM employees_projects
								)
ORDER BY e.employee_id DESC
LIMIT 5

--ex 05
SELECT e1.employee_id, e1.first_name, e1.manager_id, m.first_name as manager_name
FROM employees AS m
JOIN employees AS e1
	ON m.employee_id = e1.manager_id 
WHERE m.employee_id = 3 
	OR m.employee_id = 7
ORDER BY  e1.first_name ASC 

--ex 06
SELECT salary, `name`
FROM employees AS e
JOIN departments AS d
	ON e.department_id = d.department_id
ORDER BY e.salary asc
LIMIT 1

--ex 07
SELECT * 
FROM countries AS c
LEFT JOIN mountains_countries AS mc
	ON mc.country_code = c.country_code
WHERE mountain_id IS NULL	

USE geography


SELECT * FROM countries
SELECT * FROM mountains_countries
SELECT * FROM mountains