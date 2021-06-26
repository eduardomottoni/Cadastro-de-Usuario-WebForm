CREATE PROC VeiculoViewPorID
@VeiculoID int
AS
	BEGIN
	SELECT *
	FROM Veiculo
	WHERE VeiculoID= @VeiculoID
	END