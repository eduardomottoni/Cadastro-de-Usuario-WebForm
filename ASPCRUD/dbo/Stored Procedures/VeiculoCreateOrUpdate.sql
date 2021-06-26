CREATE PROC [dbo].[VeiculoCreateOrUpdate]
@VeiculoID int,
@Placa varchar (50),
@Tipo varchar (50),
@Modelo varchar(50),
@Marca varchar(50),
@Anomodelo int,
@Anofabricacao int
AS
BEGIN
IF(@VeiculoID=0)
	BEGIN
	INSERT INTO Veiculo(Placa,Tipo, Modelo, Marca, Anomodelo,Anofabricacao)
	VALUES(@Placa,@Tipo, @Modelo,@Marca,@Anomodelo,@Anofabricacao)
	END
ELSE
	BEGIN
	UPDATE Veiculo
	SET
		Placa = @Placa,
		Tipo = @Tipo,
		Modelo = @Modelo,
		Marca = @Marca,
		Anomodelo = @Anomodelo,
		Anofabricacao = @Anofabricacao
	WHERE VeiculoID = @VeiculoID
	END
END