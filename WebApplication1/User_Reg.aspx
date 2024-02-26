<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Reg.aspx.cs" Inherits="WebApplication1.User_Reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 45%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table align="center" class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Email ID</td>
                <td>
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="txtpwd" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Btn_Add" runat="server" OnClick="Btn_Add_Click" Text="ADD" />
                    <asp:Button ID="Btn_Find" runat="server" Text="FIND" OnClick="Btn_Find_Click" />
                    <asp:Button ID="BtnUpdate" runat="server" Text="UPDATE" OnClick="BtnUpdate_Click" />
                    <asp:Button ID="Btn_Del" runat="server" Text="DELETE" OnClick="Btn_Del_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
