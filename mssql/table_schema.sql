SELECT c.column_id col_id
    ,c.name col_name
    ,REPLACE(REPLACE(c.name,' ','_'),'-','_') bq_name
    --Exception, converting large precision #s with scale of 0 to bigint
    ,CASE WHEN tp.name IN ('decimal','numeric') AND c.scale = 0 THEN 'bigint'
		ELSE tp.name END col_type
    ,c.is_nullable
FROM {db}.sys.objects o
	JOIN {db}.sys.schemas s
		ON o.schema_id = s.schema_id
	JOIN {db}.sys.columns c
		ON o.object_id = c.object_id
    JOIN {db}.sys.types tp
        ON c.user_type_id = tp.user_type_id
WHERE o.name = '{table}'
AND s.name = '{schema}'
ORDER BY c.column_id ASC