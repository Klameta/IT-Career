CREATE DATABASE car_rental;

USE car_rental

CREATE TABLE categories
(
	id INT AUTO_INCREMENT,
	category varchar(50) NOT NULL,
	make VARCHAR(50),
	daily_rate FLOAT,
	monthly_rate FLOAT,
	weekend FLOAT,
	weekend_rate FLOAT,
	CONSTRAINT pk_category PRIMARY KEY	(id)
);

CREATE TABLE cars
(
	id INT AUTO_INCREMENT,
	plate_number VARCHAR(50),
	make VARCHAR(50),
	model VARCHAR(50),
	car_year INT,
	category_id INT,
	doors SMALLINT,
	picture BLOB,
	car_condition VARCHAR(50),
	available BOOL,
	CONSTRAINT pk_cars PRIMARY KEY (id),
	CONSTRAINT fk_category FOREIGN KEY (category_id)
	REFERENCES categories (id)
)


CREATE TABLE employees
(
	id INT AUTO_INCREMENT,
	first_name VARCHAR(50),
	last_name VARCHAR(50),
	title VARCHAR(50),
	notes LONGTEXT,
	CONSTRAINT pk_employees PRIMARY KEY (id)
	
)

CREATE TABLE customers
(
	id INT AUTO_INCREMENT,
	driver_license_number VARCHAR(50),
	full_name VARCHAR(50),
	address VARCHAR(50),
	city VARCHAR(50),
	zip_code SMALLINT,
	notes LONGTEXT,
	CONSTRAINT pk_customers PRIMARY KEY (id)
)

CREATE TABLE rental_orders
(
	id INT AUTO_INCREMENT,
	employee_id INT,
	customer_id INT,
	car_id INT,
	car_condition VARCHAR(50),
	tank_level FLOAT,
	kilometrage_start FLOAT,
	kilometrage_end FLOAT,
	total_kilometrage FLOAT,
	start_date DATE,
	end_date DATE,
	total_days DATE,
	rate_applied FLOAT,
	tax_rate FLOAT,
	order_status VARCHAR(50),
	notes LONGTEXT,
	CONSTRAINT pk_rental_orders PRIMARY KEY (id),
	CONSTRAINT fk_employee FOREIGN KEY (employee_id)
	REFERENCES employees (id),
	CONSTRAINT fk_customer FOREIGN KEY (customer_id)
	REFERENCES customers (id),
	CONSTRAINT fk_car FOREIGN KEY (car_id)
	REFERENCES cars (id)
)


INSERT INTO categories (category) VALUES ('Car');
INSERT INTO categories (category) VALUES ('Truck'); 
INSERT INTO categories (category) VALUES ('Van');

INSERT INTO cars (plate_number, make, model) VALUES ('A1234AA', 'Opel', 'Omega');
INSERT INTO cars (plate_number, make, model) VALUES ('A6542AB', 'Ford', 'Focus');
INSERT INTO cars (plate_number, make, model) VALUES ('OB4444AP', 'Lada', 'Niva');

INSERT INTO employees (first_name, last_name) VALUES ('Ivan', 'Ivanov');
INSERT INTO employees (first_name, last_name) VALUES ('Petar', 'Petrov');
INSERT INTO employees (first_name, last_name) VALUES ('Misha', 'Mishav');

INSERT INTO customers (driver_license_number, full_name) VALUES ('A12345', 'Ivan Ivanov Ivanov');
INSERT INTO customers (driver_licence_number, full_name) VALUES ('A12346', 'Ivan Ivanov Petrov');
INSERT INTO customers (driver_licence_number, full_name) VALUES ('A12342', 'Petar Ivanov Ivanov');

INSERT INTO rental_orders (employee_id, customer_id, car_id) VALUES (1, 2, 3);
INSERT INTO rental_orders (employee_id, customer_id, car_id) VALUES (2, 3, 1);
INSERT INTO rental_orders (employee_id, customer_id, car_id) VALUES (2, 2, 2);

