CREATE PROC ServicoCreateOrUpdate
@ServicoID int,
@Nomeserv varchar (150),
@Descricao varchar(500),
@Valor float
AS
BEGIN
IF(@ServicoID=0)
	BEGIN
	INSERT INTO Servico(Nomeserv, Descricao,Valor)
	VALUES(@Nomeserv,@Descricao,@Valor)
	END
ELSE
	BEGIN
	UPDATE Servico
	SET
		Nomeserv = @Nomeserv,
		Descricao = @Descricao,
		Valor = @Valor
	WHERE ServicoID = @ServicoID
	END
END