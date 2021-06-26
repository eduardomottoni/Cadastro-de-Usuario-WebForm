CREATE PROC ServicoDeletarPorId
@ServicoID int
AS
	BEGIN
	DELETE FROM Servico
	WHERE ServicoID = @ServicoID
	END