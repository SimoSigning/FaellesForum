<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forum.aspx.cs" Inherits="FaellesForum.Forum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Fælles Forum<br />
            Navn:<br />
            <asp:TextBox ID="NavnBox" runat="server"></asp:TextBox>
            <br />
            Email:<br />
&nbsp;<asp:TextBox ID="EmailBox" runat="server"></asp:TextBox>
            <br />
            Besked:<br />
&nbsp;<asp:TextBox ID="BeskedBox" runat="server" Height="85px"></asp:TextBox>
            <br />
            Adresse:<br />
            <asp:TextBox ID="AdresseBox" runat="server"></asp:TextBox>
            <br />
            Mobil:
            <br />
            <asp:TextBox ID="MobilBox" runat="server"></asp:TextBox>
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
</body>
</html>
