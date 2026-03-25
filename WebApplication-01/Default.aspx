<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication_01.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="test" runat="server">
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Yazı"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="btnGonder" runat="server" Text="Gönder" BackColor="Red" BorderColor="#CCFFFF" OnClick="btnGonder_Click" Style="margin-bottom: 0px" />
        </div>
        <div id="deneme">
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Onaylıyorum" />
        </div>
    </form>
</body>
</html>
