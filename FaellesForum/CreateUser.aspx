<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="FaellesForum.CreateUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Brugernavn<br />
            <asp:TextBox ID="BrugernavnTxt" runat="server"></asp:TextBox>
            <br />
            Password<br />
            <asp:TextBox ID="PasswordTxt" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="CreateUserBtn" runat="server" OnClick="Create_Click" Text="Submit" />
        </div>
    </form>
</body>
</html>
