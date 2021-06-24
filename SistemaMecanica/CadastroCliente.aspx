﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="SistemaMecanica.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro de Cliente</title>
</head>
<body>
    <form id="formcliente" method="post" runat="server">
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
                    <input type="submit" value="Submit" class="submit" />
                </div>
            </fieldset>
        </form>
    
    
</body>
</html>
