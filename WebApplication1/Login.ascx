<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="WebApplication1.Login" %>
<div class="login">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Login: "></asp:Label>
        <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
    </div>
        <asp:Label ID="Label2" runat="server" Text="Senha: "></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
    <div>
    
    </div>

    <div>
        <asp:Button ID="btnLogin" runat="server" Text="Login" />
    </div>
</div>