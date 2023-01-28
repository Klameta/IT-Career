SET default_storage_engine=InnoDB;
CREATE DATABASE minder;
USE minder;

CREATE TABLE characteristics
(
	characteristic_id INT AUTO_INCREMENT,
	title VARCHAR(255) NOT NULL,
	CONSTRAINT PK_characteristics PRIMARY KEY (characteristic_id)
);

CREATE TABLE users
(
	user_id INT(11) AUTO_INCREMENT,
	username VARCHAR(50) NOT NULL,
	email VARCHAR(255) NOT NULL,
	`password` VARCHAR(255) NOT NULL,
	first_name VARCHAR(255) NOT NULL,
	last_name VARCHAR(255) NOT NULL,
	birthdate DATE NOT NULL,
	gender ENUM("m", "f") NOT NULL,
	bio TEXT,
	latitude DOUBLE NOT NULL,
	longitude DOUBLE NOT NULL,
	profile_picture VARCHAR(50),
	CONSTRAINT users_PK PRIMARY KEY (user_id)
);

CREATE TABLE characteristics_users
(
	characteristic_id INT,
	user_id INT,
	`value` VARCHAR(255) NOT NULL,
	CONSTRAINT PK_characteristics PRIMARY KEY(characteristic_id, user_id),
	CONSTRAINT FK_characteristics FOREIGN KEY(characteristic_id)
		REFERENCES characteristics(characteristic_id),
	CONSTRAINT FK_users FOREIGN KEY(user_id)
		REFERENCES users(user_id)
);

CREATE TABLE connections
(
	`connection_id` INT AUTO_INCREMENT,
	from_user_id INT NOT null,
	to_user_id INT NOT NULL,
	accepted BOOLEAN NOT NULL,
	CONSTRAINT PK_connections PRIMARY KEY(`connection_id`),
	CONSTRAINT FK_from_users FOREIGN KEY(from_user_id)
		REFERENCES users(user_id),
	CONSTRAINT FK_to_user_id FOREIGN KEY(to_user_id)
		REFERENCES users(user_id)
);

CREATE TABLE likes
(
	liked_by_user_id INT(11) NOT null,
	liked_user_id INT(11) NOT NULL,
	CONSTRAINT PK_likes PRIMARY KEY(liked_by_user_id, liked_user_id),
	CONSTRAINT FK_liked_by_user_id FOREIGN KEY(liked_by_user_id)
		REFERENCES users(user_id),
	CONSTRAINT FK_liked_user_id FOREIGN KEY(liked_user_id)
		REFERENCES users(user_id)
);