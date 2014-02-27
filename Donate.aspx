<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donate.aspx.cs" Inherits="Donate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Welcome to the Donate Page</h1>
    </div>
        <asp:TextBox ID="txtamt" runat="server"></asp:TextBox>
        <asp:Button ID="btnDonate" runat="server" OnClick="Button1_Click" Text="Donate" />
        <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
