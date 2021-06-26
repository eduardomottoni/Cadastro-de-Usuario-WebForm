<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Servico.aspx.cs" Inherits="SistemaMecanica.Servico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:HiddenField ID="hfServicoID" runat="server" />

        <table>
            <tr>

                <td>
                    <asp:Label ID="Label1" runat="server" Text="Nome do Serviço"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtNomeserv" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Descrição do serviço"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Valor do serviço"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
                </td>
            </tr>
          
                <td></td>
                <td colspan="2">
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                    <asp:Button ID="btnDeletar" runat="server" Text="Deletar" OnClick="btnDeletar_Click" />
                    <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2">
                    <asp:Label ID="lblMensagemSucesso" runat="server" Text="" ForeColor="Green"></asp:Label>
                </td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2">
                    <asp:Label ID="lblMensagemErro" runat="server" Text="" ForeColor="Red"></asp:Label>
                </td>
            </tr>


        </table>
        <br />

        <asp:GridView ID="gvServico" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="gvServico_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Nomeserv" HeaderText="Nome do serviço" />
                <asp:BoundField DataField="Descricao" HeaderText="Descrição" />
                <asp:BoundField DataField="Valor" HeaderText="Valor" />

                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkView" runat="server" CommandArgument='<%# Eval("ServicoID") %>' OnClick="lnk_OnClick">View</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

        </asp:GridView>
        </div>
    </form>
</body>
</html>
