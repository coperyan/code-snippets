USE [dbname]
GO

SELECT a.Name as 'Table'
	,b.Name as 'Schema'
	,d.[rows] as 'RowCount'
	,SUM(e.Total_Pages) * 8 as 'TotalSpaceKB'
FROM sys.tables a
	LEFT JOIN sys.schemas b
		ON a.schema_id = b.schema_id
	LEFT JOIN sys.indexes c
		ON a.object_id = c.object_id
	LEFT JOIN sys.partitions d
		ON c.object_id = d.object_id
		AND c.index_id = d.index_id
	LEFT JOIN sys.allocation_units e
		ON d.partition_id = e.container_id
GROUP BY a.name
	,b.name
	,d.[rows]
ORDER BY SUM(e.Total_Pages) * 8 DESC