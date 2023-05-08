CREATE DATABASE hotel;
USE hotel;

CREATE TABLE employees
(
	id INT AUTO_INCREMENT,
	first_name VARCHAR(50),
	last_name VARCHAR(50),
	title VARCHAR(50),
	notes VARCHAR(1000),
	CONSTRAINT pk_employees PRIMARY KEY (id)
);

CREATE TABLE customers
(
	account_number INT AUTO_INCREMENT,
	first_name VARCHAR(50),
	last_name VARCHAR(50),
	phone_number INT,
	emergency_name VARCHAR(50),
	emergency_number INT,
	notes VARCHAR(1000),
	CONSTRAINT pk_customers PRIMARY KEY (account_number)
);

CREATE TABLE room_status
(
	room_status VARCHAR(50),
	notes VARCHAR(1000),
	CONSTRAINT pk_room_status PRIMARY KEY (room_status)
);

CREATE TABLE room_types
(
	room_type VARCHAR(50),
	notes VARCHAR(1000),
	CONSTRAINT pk_room_types PRIMARY KEY (room_type)
);

CREATE TABLE bed_types
(
	bed_type VARCHAR(50),
	notes VARCHAR(1000),
	CONSTRAINT pk_bed_types PRIMARY KEY (bed_type)
);

CREATE TABLE rooms
(
	room_number INT,
	room_type VARCHAR(50),
	bed_type varchar(50),
	rate FLOAT,
	room_status VARCHAR(50),
	notes VARCHAR(1000),
	CONSTRAINT pk_rooms PRIMARY KEY (room_number)
)


