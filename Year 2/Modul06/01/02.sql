CREATE DATABASE 

USE minions

CREATE TABLE town
(
	id INT PRIMARY KEY,
	`name` VARCHAR(50)
)

CREATE TABLE minions
(
	id INT PRIMARY KEY,
	`name` VARCHAR(50),
	age INT
)

ALTER TABLE minions
ADD towns_id INT	

ALTER TABLE minions
ADD FOREIGN KEY (towns_id) REFERENCES town (id)

ALTER TABLE town
INSERT INTO town()
VALUES(1,"Sofia"),
		(2, "Plovdiv"),
		(3, "Varna")

INSERT INTO minions(id,`name`, age, towns_id)
VALUES (1,"Kevin", 22, 1),
		(2,"Bob", 15, 3),
		(3,"Stewert",NULL , 2)
		

TRUNCATE minions

USE minions
	
CREATE TABLE users
(
	id INT PRIMARY KEY AUTO_INCREMENT,
	`name` VARCHAR(200) NOT NULL,
	 picture BLOB,
	 height DECIMAL(20,2),
	 weight DECIMAL(20,2),
	gender ENUM("f", "m") NOT SNULL,
	birtdate DATE NOT NULL,
	biography LONGTEXT
)

INSERT INTO users(`name`, picture, height, weight, gender, birtdate, biography)
			VALUES("stefcho", NULL, 23.4, 45.3, "f", NOW(), NULL),
			("stefcho", NULL, 23.4, 45.3, "f", 2000-01-01, NULL),
			("stefcho", NULL, 23.4, 45.3, "f", 2000-01-01, NULL),
			("stefcho", NULL, 23.4, 45.3, "f", 2000-01-01, NULL),
			("stefcho", NULL, 23.4, 45.3, "f", 2000-01-01, NULL),
			("stefcho", NULL, 23.4, 45.3, "f", 2000-01-01, NULL)
			
		USE minions
		

		ALTER TABLE users
		delete PRIMARY KEY;
		

USE minions
	
CREATE TABLE users1
(
	id INT NOT null auto_increment,
	`name` VARCHAR(200) NOT NULL,
	 picture BLOB,
	 height DECIMAL(20,2),
	 weight DECIMAL(20,2),
	gender ENUM("f", "m") NOT NULL,
	birtdate DATE NOT NULL,
	biography LONGTEXT,minions
	CONSTRAINT pk_users1 PRIMARY KEY (id)
)

INSERT INTO users1 (name, picture, height, weight, gender, birtdate, biography) VALUES ('Kevin', NULL, 1.82, 82.24, 'm', '2001-02-01', 'Some biography here');
INSERT INTO users1 (name, picture, height, weight, gender, birtdate, biography) VALUES ('Marie Poppinz', NULL, 1.60, 40.55, 'f', '2001-03-01', 'Some biography here');
INSERT INTO users1 (name, picture, height, weight, gender, birtdate, biography) VALUES ('Steward', NULL, 1.84, 95.00, 'm', '2001-04-01', 'Some biography here');
INSERT INTO users1 (name, picture, height, weight, gender, birtdate, biography) VALUES ('Bob Bob', NULL, 1.86, 101.99, 'm', '2001-11-06', 'Some biography here');
INSERT INTO users1 (name, picture, height, weight, gender, birtdate, biography) VALUES ('An Ann Annie', NULL, 1.72, 60.22, 'f', '2001-12-01', 'Some biography here');
	
	ALTER TABLE users1
	DROP PRIMARY KEY,
	ADD CONSTRAINT pk_users1 PRIMARY KEY(id, `name`)
	
ALTER TABLE users1
CHANGE COLUMN birtdate DATE not null DEFAULT CURRENT_TIMESTAMP;