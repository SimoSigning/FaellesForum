<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forum.aspx.cs" Inherits="FaellesForum.Forum" %>

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
    Forum
    </div>
    <div id="Maincontent">
        <form id="form1" runat="server">
            <div>
                Fælles Forum
            <asp:Label ID="Label1" runat="server" Text="Label">

            </asp:Label>
                <br />
                <asp:TextBox ID="BeskedBox" runat="server" Height="85px"></asp:TextBox>

                <br />

                <asp:Button ID="SaveBtn" runat="server" OnClick="Save_Click" Text="Save" />
                <asp:Button ID="ResetBtn" runat="server" OnClick="Reset_Click" Text="Reset" />
                <asp:Button ID="DeleteBtn" runat="server" OnClick="Delete_Click" Text="Delete all messages" />
                <asp:Button ID="ReadBtn" runat="server" Onclick="Read_Click" Text="Read all messages" />
                <br />
                <asp:Button ID="LogoutBtn" runat="server" OnClick="Logout_Click" Text="Logout"  />
                <br />
                <br />
                <asp:ListBox ID="MessageList" runat="server"></asp:ListBox>
            </div>
        </form>
    </div>
    </div>
    <div id="Footer">
        Copyright © girafentusiast foreningen
    </div>
</body>
</html>
