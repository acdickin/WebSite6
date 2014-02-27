<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Grant.aspx.cs" Inherits="Grant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Welcome to the Grant Page</h1>
        <asp:TextBox ID="txtgamt" runat="server"></asp:TextBox>
        <asp:Button ID="btnGrant" runat="server" Text="Apply" OnClick="btnGrant_Click" />
        <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
