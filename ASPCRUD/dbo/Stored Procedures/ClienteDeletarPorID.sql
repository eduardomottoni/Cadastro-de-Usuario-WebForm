CREATE PROC ClienteDeletarPorID
@ClienteID int
AS
	BEGIN
	DELETE FROM Cliente
	WHERE ClienteID = @ClienteID
	END