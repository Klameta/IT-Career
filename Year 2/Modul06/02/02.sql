CREATE DATABASE one_to_many
USING one_to_many

CREATE TABLE manufacturers
(
	id INT,
	`name` VARCHAR(50),
	established_on DATE,
	CONSTRAINT pk_manufact PRIMARY KEY(id)
)

CREATE TABLE models
(
	model_id INT,
	`name` VARCHAR(50),
	manufacturer_id INT,
	CONSTRAINT pk_models PRIMARY KEY (model_id)
)

ALTER TABLE manufacturers
ADD CONSTRAINT fk_