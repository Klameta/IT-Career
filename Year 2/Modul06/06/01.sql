USE soft_uni;
SELECT department_id, MAX(Salary), MIN(Salary), AVG(salary)
FROM employees
GROUP BY department_id

-- lab 02
SELECT e1.manager_id, e2.first_name, e2.last_name, COUNT(*) AS 'Подчинени'
FROM employees AS e1
JOIN employees AS e2
	ON e1.manager_id = e2.employee_id
GROUP BY e1.manager_id

-- lab 03
SELECT department_id, SUM(salary)
FROM employees
GROUP BY department_id
ORDER BY department_id

-- lab 04
SELECT e.department_id, `name`, COUNT(*)
FROM employees AS e
JOIN departments AS d ON d.department_id = e.department_id
GROUP BY e.department_id;

-- lab 05
SELECT department_id, SUM(salary) AS TotalSalary
FROM employees
GROUP BY department_id
HAVING TotalSalary > 150000
ORDER BY department_id



