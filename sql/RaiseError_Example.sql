USE [db]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_StoredProcedure] @Param1 INT


--Validating entered info
IF @Param1 NOT IN (SELECT DISTINCT Param FROM db..ParamValidation)
	BEGIN
		RAISERROR('Invalid parameter entered,18,11)
		RETURN
	END;


END

GO
