<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="FaellesForum.CreateUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Clientfiles/girafstyles.css" />
</head>
<body>
    <div id="Header">
        Giraf Forum
    </div>
    <div id="Content">
         <div id="Leftcontent">
        Create user ->
         </div>
        <div id="Maincontent">
            <form id="form1" runat="server">
                <div>
                    Brugernavn<br />
                    <asp:TextBox ID="BrugernavnTxt" runat="server"></asp:TextBox>
                    <br />
                    Password<br />
                    <asp:TextBox ID="PasswordTxt" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="CreateUserBtn02" runat="server" OnClick="Create_Click" Text="Submit" />
                </div>
            </form>
        </div>
    </div>
    <div id="Footer">
        Copyright © girafentusiast foreningen
    </div>
</body>
</html>
