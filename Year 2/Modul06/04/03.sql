USE soft_uni

SELECT first_name, last_name, department_id, salary
FROM employees AS e
WHERE EXISTS (
					SELECT department_id
					FROM departments AS d
					WHERE e.department_id = d.department_id AND `name` = 'Finance'
				)


SELECT first_name, last_name, department_id, salary
FROM employees 
WHERE department_id = ANY (
									SELECT department_id
									FROM departments
									WHERE `name` = 'Sales'
								  )
								  
SELECT first_name, last_name, department_id, salary
FROM employees AS e
WHERE NOT EXISTS (
						SELECT department_id FROM employees AS e
						WHERE e.department_id = d.department 
						AND `name` = 'Salary'
						)
						

SELECT first_name, last_name, employee_id, manager_id
FROM employees
WHERE `manager_id` = ANY (
									SELECT employee_id
									FROM employees AS e1
									WHERE e1.department_id = 1
								 )
ORDER BY employee_id ASC	
									
									
SELECT * FROM employees
SELECT * FROM departments

--01
SELECT DISTINCT job_title, salary
FROM employees
WHERE employee_id = ANY (
								SELECT employee_id
								FROM employees
								ORDER BY salary DESC
							)
ORDER BY salary DESC,
			job_title ASC	
			
--02
SELECT first_name, last_name, salary, (
													SELECT `name`
													FROM departments
							 						WHERE department_id = e.department_id
							 					  )
												 AS department
FROM employees AS e 
WHERE department_id = ANY (
									SELECT DISTINCT department_id
									FROM employees
									ORDER BY salary asc
								) 
ORDER BY salary ASC, 
			first_name ASC,
			last_name ASC
			
--03
SELECT first_name, last_name
FROM employees AS e
WHERE middle_name = ANY (
									SELECT middle_name
									FROM employees AS e1
									WHERE manager_id = ANY (
																	
																)
								)


	
							 