USE {db_name}
GO

--Table Usage
SELECT DB_NAME() DBName 
	,t.Name TableName
	,s.Name SchemaName
	,p.Rows RowCt
	,CAST(ROUND(((SUM(au.Used_Pages)*8)/1024.00),2) AS NUMERIC(36,2)) UsedSpaceMB
	,CAST(ROUND(((SUM(au.Used_Pages)*8)/1024.00),2) AS NUMERIC(36,2))/(Size/128.00) UsedSpacePct
FROM sys.Tables t
	JOIN sys.Indexes i
		ON t.object_id = i.object_id
	JOIN sys.Partitions p
		ON i.object_id = p.object_id
		AND i.index_id = p.index_id
	JOIN sys.allocation_units au
		ON p.partition_id = au.container_id
	LEFT OUTER JOIN sys.schemas s
		ON t.schema_id = s.schema_id
	LEFT JOIN sys.database_files df
		ON df.Type_desc = 'ROWS'
WHERE t.is_ms_shipped = 0
AND i.object_id >= 255
GROUP BY t.Name
	,s.Name
	,p.Rows
	,df.Size
ORDER BY CAST(ROUND(((SUM(au.Used_Pages)*8)/1024.00),2) AS NUMERIC(36,2)) DESC

--DB Usage
SELECT DB_NAME() DBName
	,Name AS FName
	,Type_Desc FTypeDesc
	,Size/128.00 AS CurrentSizeMB
	,Size/128.00 - CAST(FILEPROPERTY(name,'SpaceUsed') AS INT)/128.00 AS FreeSpaceMB
	,(Size/128.00 - CAST(FILEPROPERTY(name,'SpaceUsed') AS INT)/128.00)/(Size/128.00) FreeSpacePct
FROM sys.database_files df
WHERE type IN (0,1)