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
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Email:<br />
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Besked:<br />
&nbsp;<asp:TextBox ID="TextBox3" runat="server" Height="85px"></asp:TextBox>
            <br />
            Adresse:<br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            Mobil:
            <br />
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Save" />
            <asp:Button ID="Button2" runat="server" Text="Reset" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete all messages" />
            <asp:Button ID="Button4" runat="server" Text="Read all messages" />
            <br />
            <asp:Button ID="Button5" runat="server" Text="Logout" />
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        </div>
    </form>
</body>
</html>
