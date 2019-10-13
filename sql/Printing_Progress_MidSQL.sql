DECLARE @MSG VARCHAR(100) = NULL;

EXEC database.schema.usp_StoredProcedure

SET @MSG = 'Stored Proc Complete ' + CONVERT(VARCHAR(20), GETDATE())
RAISERROR(@MSG,0,1) WITH NOWAIT;
