CREATE PROC VeiculoDeletarPorId
@VeiculoID int
AS
	BEGIN
	DELETE FROM Veiculo
	WHERE VeiculoID = @VeiculoID
	END