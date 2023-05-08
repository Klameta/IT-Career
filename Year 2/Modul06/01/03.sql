CREATE DATABASE Movies;
USE Movies;

CREATE TABLE directors
(
	id INT NOT NULL AUTO_INCREMENT,
	director_name VARCHAR(50) NOT NULL,
	notes LONGTEXT	,
	CONSTRAINT pk_directors PRIMARY KEY(id)
)

CREATE TABLE genres
(
	id INT NOT NULL AUTO_INCREMENT,
	gerne_name VARCHAR(50) NOT NULL,
	notes LONGTEXT,
	CONSTRAINT pk_genres PRIMARY KEY (id)
);

CREATE TABLE categories
(
	id INT NOT NULL AUTO_INCREMENT,
	category_name VARCHAR(50) NOT NULL,
	notes LONGTEXT,
	CONSTRAINT pk_categories PRIMARY KEY (id)
)

CREATE TABLE movies
(
	id INT NOT NULL AUTO_INCREMENT,
	title VARCHAR(50) NOT NULL,
	director_id INT NOT NULL,
	copyright_year SMALLINT,
	lenght INT,
	gerne_id INT NOT NULL,
	category_id INT,
	rating DOUBLE,
	notes LONGTEXT,
	CONSTRAINT pk_movies PRIMARY KEY (id),
	CONSTRAINT fk_directorId FOREIGN KEY (director_id)
	REFERENCES directors (id),
	CONSTRAINT fk_gerneId FOREIGN KEY (gerne_id)
	REFERENCES genres (id)
)


INSERT INTO directors (director_name, notes) VALUES ('Ben Affleck', 'sample notes');
INSERT INTO directors (director_name, notes) VALUES ('Woody Allen', 'sample notes');
INSERT INTO directors (director_name, notes) VALUES ('Luc Besson', 'sample notes');
INSERT INTO directors (director_name, notes) VALUES ('Cameron Crowe', 'sample notes');
INSERT INTO directors (director_name, notes) VALUES ('Clint Eastwood', 'sample notes');

INSERT INTO genres (gerne_name, notes) VALUES ('Action', 'sample notes');
INSERT INTO genres (gerne_name, notes) VALUES ('Comedy', 'sample notes');
INSERT INTO genres (gerne_name, notes) VALUES ('Horror', 'sample notes');
INSERT INTO genres (gerne_name, notes) VALUES ('Thriller', 'sample notes');
INSERT INTO genres (gerne_name, notes) VALUES ('Drama', 'sample notes');

INSERT INTO categories (category_name, notes) VALUES ('0-3', 'suitable for infants');
INSERT INTO categories (category_name, notes) VALUES ('7-12', 'suitable for kids');
INSERT INTO categories (category_name, notes) VALUES ('12-16', 'suitable for teenagers');
INSERT INTO categories (category_name, notes) VALUES ('16-18', NULL);
INSERT INTO categories (category_name, notes) VALUES ('18+', 'suitable for adults');

INSERT INTO movies (title, director_id, copyright_year, lenght, gerne_id, category_id, rating, notes) VALUES ('Titanic', 1, 1998, 181, 1, 4, 8.2, 'sample notes');
INSERT INTO movies (title, director_id, copyright_year, lenght, gerne_id, category_id, rating, notes) VALUES ('Avatar', 4, 2008, 160, 2, 3, 9.22, 'sample notes');
INSERT INTO movies (title, director_id, copyright_year, lenght, gerne_id, category_id, rating, notes) VALUES ('Rocky 1', 2, 1980, 90, 3, 1, 9.99, 'sample notes');
INSERT INTO movies (title, director_id, copyright_year, lenght, gerne_id, category_id, rating, notes) VALUES ('Rocky 2', 3, 1983, 92, 5, 2, 10.1, 'sample notes');
INSERT INTO movies (title, director_id, copyright_year, lenght, gerne_id, category_id, rating, notes) VALUES ('Rocky 3', 1, 1986, 95, 1, 5, 6.2, 'sample notes');



