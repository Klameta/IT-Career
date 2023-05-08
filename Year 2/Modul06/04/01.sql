
SELECT country_name, country_code,
		(
			case when currency_code = 'EUR'
			then 'Euro'
			ELSE 'Not Euro'
		   END 
		) AS Currency
FROM countries
ORDER BY country_name ASC;
