CREATE PROC ServicoViewPorID
@ServicoID int
AS
	BEGIN
	SELECT *
	FROM Servico
	WHERE ServicoID= @ServicoID
	END