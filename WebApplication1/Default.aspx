<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

            <asp:DropDownList ID="ddlContatos" runat="server">

            </asp:DropDownList>
            <br />
            <br />
            <br />
            <div id="selectManual" runat="server">
                <!-- < % foreach (var contato in contatos){ % >
                    <option value="< % = contato.Id % >">< % = contato.Nome % ></option>
                 < %} % >
                -->
             </div>
        
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        
        <br />
        <br />     
        <br />
        Id:
        <asp:TextBox ID="txtId" runat="server" Width="34px"></asp:TextBox>
        <br />
        Nome:
        <asp:TextBox ID="txtNome" runat="server" Width="34px"></asp:TextBox>
        <br />
        Telefone:<asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
&nbsp;<br />
        <asp:Button ID="btnGravar" runat="server" OnClick="btnGravar_Click" Text="Gravar" />
        <br />
        <asp:ListView ID="ListView1" runat="server"></asp:ListView>
        <br />
    </form>

    </body>
</html>
