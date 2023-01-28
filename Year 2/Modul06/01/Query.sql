USE soft_uni;
SELECT * FROM people;

INSERT INTO people(id, email, first_name, last_name)
			VALUES (1, "name@domain.com", "Emily", "Dobreva")

INSERT INTO people()
			VALUES(6, "kathrenee@domain.com", "Kathrene", "Applesause");
			
CREATE TABLE people1
(
	id INT PRIMARY KEY AUTO_INCREMENT,
	email VARCHAR(50) NOT NULL UNIQUE,
	first_name VARCHAR(50),
	last_name VARCHAR(50),
	balance DECIMAL(10,2) DEFAULT 0,
	town VARCHAR(50) DEFAULT "Haskovo"
)

INSERT INTO people1(email, first_name, last_name)
				VALUES("sasdasdas@asd.com", "asd", "asd"),
				("dfsdf@sdf.asdf", "asdf", "fdg");
			