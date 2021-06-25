<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroServico.aspx.cs" Inherits="SistemaMecanica.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    </head>
<body>
    
    <div class="container body-content">
        <div class="jumbotron">
            <div class="col-xs-offset-1">
                <!--#include file="nav-top.txt"-->
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
                            <input type="text" name="valor" value="" />
                        </div>
                        <div>
                            <label>&nbsp;</label>
                            <input type="submit" value="Submit" class="submit" />
                        </div>
                    </fieldset>
                </form>

            </div>
            <br />
             <asp:Literal ID = "ltTable" runat = "server" /> <!-- Esse código é reposável pela geração das tabelas abaixo após o envio do post -->
        <br />
        </div>
        <!--#include file="footer.txt"-->
    </div>
</body>
</html>
