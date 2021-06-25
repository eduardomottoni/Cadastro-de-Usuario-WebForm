<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="SistemaMecanica.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro de Cliente</title>
    
        <%: Scripts.Render("~/bundles/modernizr") %>
 

    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    </head>
<body>
    <div class="container body-content">  <!-- Classe utilizada do Site.Master -->
    <div class="jumbotron">  <!-- Classe utilizada do Site.Master -->
        <div class="col-xs-offset-1">
            <!--#include file="nav-top.txt"-->                           <!-- Include da barra de navegação -->
            <form id="formcliente" method="post" runat="server">  <!-- Formulário para o cadastro de um novo cliente -->
                <fieldset>
                    <legend>Novo Cliente</legend>
                    <div>
                        <label for="Nome">Nome:</label>
                        <input type="text" name="Nome" value="" />
                    </div>
                    <div>
                        <label for="email">E-mail:</label>
                        <input type="text" name="email" value="" />
                    </div>
                    <div>
                        <label for="endereco">Endereço:</label>
                        <input type="text" name="endereco" value="" />
                    </div>
                    <div>
                        <label for="cpf">CPF:</label>
                        <input type="text" name="cpf" value="" />
                    </div>
                    <div>
                        <label>&nbsp;</label>
                        <input type="submit" value="Adicionar Cliente" class="submit" />
                    </div>

                </fieldset>
            </form>
            <div id="confirmacaocliente" style="visibility:hidden" runat="server"> <p> O cliente foi cadastrado.</p></div>
        </div>


         <br />
        <asp:Literal ID = "ltTable" runat = "server" /> <!-- Esse código é reposável pela geração das tabelas abaixo após o envio do post -->
        <br />

        
        </div>
        <!--#include file="footer.txt"-->
    </div>
</body>
</html>
