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
    <form id="form1" runat="server">
    <div id="Content" aria-atomic="False">
    <div id="Leftcontent">
        Velkommen
        <asp:Label ID="brugernavnlabel" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="LogoutBtn" runat="server" OnClick="Logout_Click" Text="Logout"  />
    </div>
    <div id="Maincontent">
            <div>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;<table id="forumtable">
                    <tr>
                      <th>
                          Post a message
                      </th>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="BeskedBox" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button class="ForumBtns" ID="SaveBtn" runat="server" OnClick="Save_Click" Text="Save" />
                            <asp:Button class="ForumBtns" ID="ReadBtn" runat="server" Onclick="Read_Click" Text="Read all messages" />
                            <asp:Button class="ForumBtns" ID="ResetBtn" runat="server" OnClick="Reset_Click" Text="Reset" />
                            <asp:Button class="ForumBtns" ID="DeleteBtn" runat="server" OnClick="Delete_Click" Text="Delete all messages" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ListBox ID="MessageList" runat="server" EnableTheming="False"></asp:ListBox>
                        </td>
                    </tr>
                </table>
                
                
                
                
                
                <br />
               
            </div>
    </div>
    </div>
    </form>
    <div id="Footer">
        Copyright © girafentusiast foreningen
    </div>
</body>
</html>
