<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Veiculo.aspx.cs" Inherits="SistemaMecanica.Veiculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
        <asp:HiddenField ID="hfVeiculoID" runat="server" />

        <table>
            <tr>

                <td>
                    <asp:Label ID="Label1" runat="server" Text="Placa"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtPlaca" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Tipo"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Marca"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Modelo"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Ano do modelo"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtAnomodelo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Ano de fabricação"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtAnofabricacao" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
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

        <asp:GridView ID="gvVeiculo" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="gvVeiculo_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Placa" HeaderText="Placa" />
                <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                <asp:BoundField DataField="Marca" HeaderText="Marca" />
                <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                <asp:BoundField DataField="Anomodelo" HeaderText="Anomodelo" />
                <asp:BoundField DataField="Anofabricacao" HeaderText="Anofabricacao" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkView" runat="server" CommandArgument='<%# Eval("VeiculoID") %>' OnClick="lnk_OnClick">View</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

        </asp:GridView>
        </div>
    </form>
</body>
</html>
