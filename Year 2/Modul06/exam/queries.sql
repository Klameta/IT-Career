SELECT title
FROM characteristics
ORDER BY title ASC
LIMIT 5;

SELECT from_user_id, to_user_id, accepted
FROM connections AS c
WHERE c.from_user_id = 481
	AND accepted = 1
ORDER BY to_user_id DESC 

SELECT username
FROM users AS u
JOIN likes AS l
	ON u.user_id = l.liked_user_id
GROUP BY user_id
ORDER BY COUNT(liked_by_user_id) DESC
LIMIT 3

SELECT user_id, username, first_name, last_name
FROM users AS u
LEFT JOIN likes AS l
	ON l.liked_user_id = u.user_id
WHERE l.liked_by_user_id IS NULL
ORDER BY first_name ASC,
			last_name asc
LIMIT 10

SELECT username 
FROM users AS u
JOIN characteristics_users AS cu
	ON u.user_id = cu.user_id
WHERE cu.value = "blue"
	AND u.gender = "f"
	AND date(u.birthdate) >= DATE("1990-01-01")
	AND DATE(u.birthdate) <= DATE("1999-12-31")
ORDER BY username desc



SELECT (SELECT Round(AVG(`value`), 2)
			FROM characteristics_users
			WHERE characteristic_id = 1
		 ) AS average_height

SELECT u_liked_by.username as liked_by,
 u_liked.username as liked,
 cu1.value AS liked_by_eye_color,
 cu.value AS liked_eye_color
FROM users AS u_liked
JOIN likes AS l_liked
	ON l_liked.liked_user_id = u_liked.user_id 
JOIN users AS u_liked_by
	ON u_liked_by.user_id = l_liked.liked_by_user_id
JOIN characteristics_users AS cu
	ON u_liked.user_id = cu.user_id
JOIN characteristics_users AS cu1
	ON u_liked_by.user_id = cu1.user_id
WHERE cu.characteristic_id = 3
	AND cu.value IS NOT NULL
	AND cu1.characteristic_id =3
	AND cu1.value IS NOT null
ORDER BY u_liked_by.username,
			u_liked.username
LIMIT 5

SELECT * FROM characteristics
SELECT * FROM characteristics_users
SELECT * FROM users
SELECT * FROM likes
SELECT * FROM connections