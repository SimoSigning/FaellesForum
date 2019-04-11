<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forum.aspx.cs" Inherits="FaellesForum.Forum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Clientfiles/girafstyles.css" />
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
</head>
<body>
    <div id="Header">
        Giraf Forum
    </div>
    <form id="form1" runat="server">
    <div id="Content" aria-atomic="False">
    <div id="Leftcontent">
    Forum
    <br />
    <asp:Button ID="LogoutBtn" runat="server" OnClick="Logout_Click" Text="Logout"  />
    </div>
    <div id="Maincontent">
            <div>
            Fælles Forum
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <table>
                    <tr>
                      <th>
                          Post a message
                      </th>
                    </tr>
                    <tr>
                        <td class="auto-style1"></td>
                        <td class="auto-style1"></td>
                    </tr>
                </table>
                <asp:TextBox ID="BeskedBox" runat="server" Height="85px"></asp:TextBox>
                <asp:Button ID="SaveBtn" runat="server" OnClick="Save_Click" Text="Save" />
                <asp:Button ID="ResetBtn" runat="server" OnClick="Reset_Click" Text="Reset" />
                <asp:Button ID="DeleteBtn" runat="server" OnClick="Delete_Click" Text="Delete all messages" />
                <asp:Button ID="ReadBtn" runat="server" Onclick="Read_Click" Text="Read all messages" />
                <asp:ListBox ID="MessageList" runat="server" Height="138px" Width="533px" EnableTheming="False"></asp:ListBox>
            </div>
    </div>
    </div>
    </form>
    <div id="Footer">
        Copyright © girafentusiast foreningen
    </div>
</body>
</html>
