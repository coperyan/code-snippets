DECLARE @CustomerID INT

DECLARE @Customers TABLE ([CustomerID] INT);
INSERT INTO @Customers
SELECT DISTINCT CustomerID
FROM Customers

DECLARE cur CURSOR FOR SELECT CutomerID FROM @Customers
OPEN cur

FETCH NEXT FROM cur INTO @CustomerID

WHILE @@FETCH_STATUS = 0 BEGIN
	EXECUTE [dbo].[customerSP] @CustomerID = @CustomerID
	FETCH NEXT FROM cur INTO @CustomerID
END

CLOSE cur
DEALLOCATE cur
