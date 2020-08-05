<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="WebApplication1.Cadastro" %>
<%@ Register src="Login.ascx" tagname="Login" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        img 
        {
            width:100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:Login ID="Login1" runat="server" />
    </div>
    <div><hr/></div>

    <div>
        <asp:Panel ID="pnlCamposCadastro" runat="server" Height="111px">
            Id<asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <br />
            Nome<asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            Telefone<asp:TextBox ID="txtTelefone" runat="server" Width="126px"></asp:TextBox>
            <br />
            Foto<asp:FileUpload ID="fileFoto" runat="server" />
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="Button1_Click" />
            <asp:Button ID="Limpar" runat="server" OnClick="Limpar_Click" Text="Limpar lista" />
            <br />
        </asp:Panel>
    </div>
        <br />
        <br />
            <hr style="margin-bottom: 0px" />
            <br />
        <asp:Panel ID="pnlResultado" runat="server">
            <asp:GridView ID="grdResultado" runat="server" AutoGenerateColumns="False" HorizontalAlign="Justify" Width="512px" style="margin-right: 0px">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID" />
                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                    <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                    <asp:ImageField DataImageUrlField="Foto" HeaderText="Foto" DataImageUrlFormatString="~/{0}">
                        <ControlStyle Width="100px" />
                        <ItemStyle Width="100px" />
                    </asp:ImageField>
                </Columns>
            </asp:GridView>
            <asp:Button ID="btnVoltar" runat="server" Text="Voltar" />
        </asp:Panel>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

