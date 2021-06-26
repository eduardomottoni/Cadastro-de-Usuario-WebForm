CREATE PROC [dbo].[ClienteCreateOrUpdate]
@ClienteID int,
@Nome varchar (50),
@Email varchar(50),
@Endereco varchar(250),
@Cpf int
AS
BEGIN
IF(@ClienteID=0)
	BEGIN
	INSERT INTO Cliente(Nome, Email, Endereco, Cpf)
	VALUES(@Nome,@Email,@Endereco,@Cpf)
	END
ELSE
	BEGIN
	UPDATE Cliente
	SET
		Nome = @Nome,
		Email = @Email,
		Endereco = @Endereco,
		Cpf = @Cpf
	WHERE ClienteID = @ClienteID
	END
END