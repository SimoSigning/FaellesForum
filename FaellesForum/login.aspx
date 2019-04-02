<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="FaellesForum.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Fælles Forum"></asp:Label>
            <br />
            <br />
            Tast brugernavn og password<br />
            <br />
            Brugernavn
            <asp:TextBox ID="BrugernavnBtn" runat="server"></asp:TextBox>
            <br />
            <br />
            Password
            <asp:TextBox ID="PasswordBtn" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="LoginBtn" runat="server" OnClick="Login_Click" Text="Login" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CreateUserBtn" runat="server" OnClick="CreateUserBtn_Click" Text="Create user"  />
        </div>
    </form>
</body>
</html>
