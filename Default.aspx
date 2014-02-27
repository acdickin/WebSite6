<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>Enter First Name</td>
                <td><asp:TextBox ID="txtfirst" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Enter Last Name</td>
                <td><asp:TextBox ID="txtlast" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Enter E-mial</td>
                <td><asp:TextBox ID="txtemail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Enter Password</td>
                <td><asp:TextBox ID="txtpassword" runat="server"></asp:TextBox></td>
            </tr>
             <tr>

                <td>Comfirm</td>
                <td><asp:TextBox ID="txtconfirm" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td style="margin-left: 40px"><asp:Button ID="btnsubmit" runat="server" Text="submit" OnClick="btnsubmit_Click" /></td>
                <td> <asp:Label ID="lblerror" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
