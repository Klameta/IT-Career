--01
USE soft_uni
SELECT first_name, last_name, salary
FROM employees
WHERE salary = (
						SELECT salary
						FROM employees
						ORDER BY salary
						LIMIT 1
					)
	
--02
SELECT first_name, last_name, salary
FROM employees
WHERE salary = ANY (
						SELECT salary 
						FROM employees
						WHERE salary <= 1.1 * (
														SELECT salary
														FROM employees
														ORDER BY salary asc
														LIMIT 1
													 )
						 )
ORDER BY salary ASC,
			first_name ASC
			
--03
SELECT first_name, last_name, job_title
FROM employees 
WHERE employee_id = ANY (
								SELECT manager_id
								FROM employees
								)
ORDER BY first_name ASC,
			last_name ASC
			
--04
SELECT first_name, last_name
FROM employees
WHERE address_id = ANY (
								 SELECT address_id
								 FROM addresses
								 WHERE town_id = ANY (
								 								SELECT town_id
								 								FROM towns
								 								WHERE `name` = 'San Francisco'
															)	
							  )
ORDER BY FIRST_name ASC
								
								