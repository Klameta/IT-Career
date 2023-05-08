USE soft_uni
SET GLOBAL log_bin_trust_function_creators = 1

-- lab 01
delimiter $$
CREATE FUNCTION udf_projects_weeks (start_date DATETIME, end_date DATETIME)
RETURNS INT
BEGIN	
	DECLARE project_weeks INT;
	if (end_date IS NULL)
	then SET end_date = NOW();
	END if;
	SET project_weeks = DATEDIFF(DATE(end_date), DATE(start_date))/7;
	RETURN project_weeks;
END	

-- lab 02
DELIMITER $$
CREATE FUNCTION udf_salary_level (salary DECIMAL)
RETURNS VARCHAR(10)
BEGIN
	DECLARE salary_level VARCHAR(10);
	if (salary< 30000)
		then SET salary_level = "Low";
		END if;
	if (salary <= 50000)
		then SET salary_level = "Average";
		END if;
	if (salary > 50000)
		then SET salary_level = "High";
		END if;
	RETURN salary_level;
END
$$

SELECT first_name, last_name, salary, udf_salary_level(salary) AS salary_level
FROM employees;

-- lab 03
DELIMITER $$
CREATE function udf_count_employees_by_town(town_name VARCHAR(20))
RETURNS INT
BEGIN
	DECLARE e_count INT;
	SET e_count := (SELECT COUNT(*)
						FROM employees AS e
						JOIN addresses AS a 
							ON a.address_id = e.address_id
						JOIN towns AS t
							ON t.town_id = a.town_id
						WHERE t.name = town_name);
	RETURN e_count;
END	
$$

-- 
DELIMITER $$
CREATE PROCEDURE udp_select_employees_by_senioritty()
BEGIN
	SELECT * FROM employees
	WHERE ROUND(DATEDIFF(NOW(), hire_date)/365.25)<15;
END
$$
CALL udp_select_employees_by_senioritty()

--
delimiter $$
CREATE PROCEDURE udp_select_employees_by_seniority1(min_years_at_work INT)
BEGIN
	SELECT first_name, last_name, hire_date,
			ROUND(DATEDIFF(NOW(), hire_date)/365.25) AS years
	FROM employees
	WHERE ROUND(DATEDIFF(NOW(), hire_date)/365.25)<= min_years_at_work;
END
$$

CALL udp_select_employees_by_seniority1(24)

--
delimiter $$
CREATE PROCEDURE usp_sum_two_numbers(first_number INT,
												second_number INT,
												OUT result INT)
BEGIN
	SET result = first_number + second_number;
END
$$

SET @answer = 0;
CALL usp_sum_two_numbers(182, 232, @answer);
SELECT @answer;
--
USE soft_uni;

delimiter $$
CREATE PROCEDURE usp_raise_salaries(department_name VARCHAR(50))
BEGIN 
	UPDATE employees AS e
	JOIN departments AS d
		ON e.department_id = d.department_id
	SET e.salary = e.salary * 1.05
	WHERE d.name = department_name;
END $$

CALL usp_raise_salaries("Engineering")

--
delimiter $$
CREATE PROCEDURE usp_raise_salaries_by_id(id INT)
BEGIN
	START TRANSACTION;
	if((SELECT COUNT(employee_id) FROM employees WHERE employee_id = id) <> 1)
	then ROLLBACK;
	ELSE 
		UPDATE employees AS e
		SET salary = salary *1.05
		WHERE e.employee_id = id;
	END if;
END $$;

CALL usp_raise_salaries_by_id(1)

DROP procedure usp_raise_salaries_by_id

--
CREATE TABLE employees_projects_history(
			employee_id INT NOT NULL,
			project_id INT NOT NULL,
			PRIMARY KEY (employee_id, project_id)
);

delimiter $$
CREATE TRIGGER tr_delete_records
AFTER DELETE
ON employees_projects
FOR EACH ROW
BEGIN
	INSERT INTO employees_project_history(employee_id, project_id)
					VALUES(OLD.employee_id, OLD.project_id);
END	
$$

DELETE FROM employees_projects
WHERE employee_id = 4
