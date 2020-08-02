<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="WebApplication1.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="pnlCamposCadastro" runat="server" Height="111px">
            Id<asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <br />
            Nome<asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            Telefone<asp:TextBox ID="txtTelefone" runat="server" Width="126px"></asp:TextBox>
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="Button1_Click" />
            <br />
        </asp:Panel>
    </div>
        <asp:Panel ID="pnlResultado" runat="server">
            <asp:GridView ID="grdResultado" runat="server">
            </asp:GridView>
            <asp:Button ID="btnVoltar" runat="server" Text="Voltar" />
        </asp:Panel>
    </form>
</body>
</html>

