<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h1>Welcome</h1>
         <table>
            <tr>
                <td>Donate</td>
                <td>
                    <asp:Button ID="btnDonate" runat="server" Text="Donate" /></td>
            </tr>
             <tr>
                <td>Apply For Grant</td>
                <td>
                    <asp:Button ID="btnGrant" runat="server" Text="Grant" OnClick="btnGrant_Click" /></td>
            </tr>

        </table>
    </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
