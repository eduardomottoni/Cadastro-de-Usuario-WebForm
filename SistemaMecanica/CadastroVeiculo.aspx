<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroVeiculo.aspx.cs" Inherits="SistemaMecanica.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro de veículo</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
</head>
<body>
    
    <div class="container body-content"> <!-- Classe utilizada do Site.Master -->
        <div class="jumbotron">
            <div class="col-xs-offset-1">
                <!--#include file="nav-top.txt"-->

                <form id="formveiculo" method="post" runat="server">
                    <fieldset>
                        <legend>Novo Veículo</legend>
                        <div>
                            <label for="placa">Placa:</label>
                            <input type="text" name="placa" value="" />
                        </div>
                        <div>
                            <label for="tipo">Tipo:</label>
                            <input type="text" name="tipo" value="" />
                        </div>
                        <div>
                            <label for="marca">Marca:</label>
                            <input type="text" name="marca" value="" />
                        </div>
                        <div>
                            <label for="modelo">Modelo:</label>
                            <input type="text" name="modelo" value="" />
                        </div>
                        <div>
                            <label for="anomodelo">Ano do modelo:</label>
                            <input type="text" name="anomodelo" value="" />
                        </div>
                        <div>
                            <label for="anofabricacao">Ano de fabricação:</label>
                            <input type="text" name="anofabricacao" value="" />
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
