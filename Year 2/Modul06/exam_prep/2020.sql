CREATE DATABASE planet_system;

CREATE TABLE planets
(
	id INT(11) NOT NULL,
	NAME varchar(30) NOT NULL,
	size DOUBLE(20,1) NOT NULL,
	min_temperature DOUBLE(7,2),
	max_temperature DOUBLE(7,2),
	galaxy_name VARCHAR(50),
	CONSTRAINT pk_planets PRIMARY KEY(id)
);
DROP TABLE satellites
CREATE TABLE satellites
(
	id INT NOT NULL,
	NAME VARCHAR(40) NOT NULL,
	planet_id INT(11) NOT NULL,
	distance_from_planet INT(11) NOT NULL,
	found_date DATE,
	CONSTRAINT pk_satellites PRIMARY KEY (id),
	CONSTRAINT fk_planets_satellites FOREIGN KEY (planet_id)
	REFERENCES planets (id)
);

CREATE TABLE races
(
	id INT NOT NULL,
	NAME VARCHAR(30),
	CONSTRAINT pk_races PRIMARY KEY (id)
);
 
CREATE TABLE people 
(
	id INT NOT NULL,
	first_name VARCHAR(80) NOT NULL,
	last_name VARCHAR(80),
	birth_date DATE,
	planet_id INT(11) NOT NULL,
	race_id INT(11) NOT NULL,
	CONSTRAINT pk_people PRIMARY KEY (id),
	CONSTRAINT fk_planets_people FOREIGN KEY (planet_id)
	REFERENCES planets (id),
	CONSTRAINT fk_races_people FOREIGN KEY (race_id)
	REFERENCES races (id)
);

CREATE TABLE robots
(
	id INT(11) NOT NULL,
	model VARCHAR(50) NOT NULL,
	generation INT(11) NOT null,
	serial_number VARCHAR(255) NOT NULL,
	developed_date DATE NOT null,
	is_active TINYINT(1),
	person_id INT(11),
	CONSTRAINT pk_robots PRIMARY KEY (id),
	CONSTRAINT fk_people_robots FOREIGN KEY (person_id)
	REFERENCES people (id)
);

