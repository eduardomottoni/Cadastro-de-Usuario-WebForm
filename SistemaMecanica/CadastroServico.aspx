<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroServico.aspx.cs" Inherits="SistemaMecanica.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="formservico" method="post" runat="server">
            <fieldset>
                <legend>Novo Serviço</legend>
                <div>
                    <label for="nomeserv">Nome do serviço:</label>
                    <input type="text" name="nomeserv" value="" />
                </div>
                <div>
                    <label for="descricao">Descrição do serviço:</label>
                    <input type="text" name="descricao" value="" />
                </div>
                <div>
                    <label for="valor">Valor:</label>
                    <input type="text" name="valor" value="0,0" />
                </div>
                <div>
                    <label>&nbsp;</label>
                    <input type="submit" value="Submit" class="submit" />
                </div>
            </fieldset>
        </form>
</body>
</html>
