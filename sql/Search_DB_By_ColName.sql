USE [db]

SELECT *
FROM INFORMATION_SCHEMA.COLUMNS
WHERE COLUMN_NAME LIKE '%colstring%'
ORDER BY TABLE_NAME
