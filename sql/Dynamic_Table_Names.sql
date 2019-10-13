


DECLARE @tablename VARCHAR(100) = 'tablename';

DECLARE @query VARCHAR(MAX) = 'SELECT * FROM ' + @tablename  + ';';

EXEC(@query)
