SELECT a.*, b.MatchedCol
FROM table1 a
	LEFT JOIN table2 b
		ON a.col1 LIKE '%' + b.col2 + '%'
WHERE b.MatchedCol IS NOT NULL
