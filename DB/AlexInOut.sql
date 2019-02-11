CREATE DATABASE alex_in_out;
USE alex_in_out;

-- Category Names Table.
CREATE TABLE category_names
(
    category CHAR(20) NOT NULL,
    type_ CHAR(3) NOT NULL,
    PRIMARY KEY (category, type_)
);



-- Registered Table.
CREATE TABLE registered
(
	category_name CHAR(20),
    category_type CHAR(3),
    value_ DECIMAL(7, 2) NOT NULL,
    date_in DATE NOT NULL,
    FOREIGN KEY (category_name, category_type) REFERENCES category_names (category, type_)
);



-- Get Analysis Procedure.
DELIMITER $$
CREATE PROCEDURE get_analysis(IN in_category_name CHAR(20), IN in_category_type CHAR(3), 
							  IN in_date_from DATE, IN in_date_to DATE)
	BEGIN
		SELECT *, COUNT(category_name) AS amount
        FROM registered
        WHERE category_name = in_category_name AND category_type = in_category_type AND
			  (date_in BETWEEN in_date_from AND in_date_to)
		GROUP BY (category_name);
	END$$
DELIMITER ;