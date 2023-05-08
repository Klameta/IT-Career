CREATE DATABASE one_to_one;
USE one_to_one

CREATE TABLE Persons
(
	person_id INT AUTO_INCREMENT,
	first_name VARCHAR(50),
	salary FLOAT,
	passport_id INT NOT NULL,
	CONSTRAINT pk_persons PRIMARY KEY (person_id)
);

CREATE TABLE passports
(
	passport_id INT NOT NULL,
	passport_number VARCHAR(50),
	CONSTRAINT pk_passport PRIMARY KEY (passport_id)
)

ALTER TABLE persons
ADD CONSTRAINT fk_passport FOREIGN KEY (passport_id)
REFERENCES passports (passport_id);

INSERT INTO passports()
			VALUES (101, "N34FG21B"),
					(102, "K65LO4R7"),
					(103, "ZE657QP2")

INSERT INTO persons(first_name, salary, passport_id)
			VALUES ("Roberto", 43300.00, 102),
					("Tom",56100.00,103),
					("Yana", 60200.00, 101)
					
					