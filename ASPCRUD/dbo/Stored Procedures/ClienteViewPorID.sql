CREATE PROC ClienteViewPorID
@ClienteID int
AS
	BEGIN
	SELECT *
	FROM Cliente
	WHERE ClienteID = @ClienteID
	END