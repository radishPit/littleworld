<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userResetPwd.aspx.cs" Inherits="littleworld.Web.userResetPwd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    .style1{margin:auto;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" class="style1">
    
        <table style="width: 800px; height: 267px;border:1px solid #ccc" align="center" 
            border="1">
        <tr>
        <td colspan="3" align="left">
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="重置密码:"></asp:Label>
            </td>
        </tr>
            <tr>
                <td>
                    <asp:Label ID="lblpwd" runat="server" Text="请输入新密码:" ForeColor="#999999"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtpwd" runat="server" Height="28px" Width="153px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblmsg1" runat="server" Text="密码由6—16位半角字符（字母、数字、符号）组成，区分大小写" 
                        BackColor="#CCFF99"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblpwdagain" runat="server" Text="请再输入新密码:" ForeColor="#999999"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtpwdagain" runat="server" Height="25px" Width="150px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblmsg2" runat="server" Text="密码由6—16位半角字符（字母、数字、符号）组成，区分大小写" 
                        BackColor="#CCFF99"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="btnOK" runat="server" Height="31px" Text="确定" Width="70px" 
                        Font-Bold="True" onclick="btnOK_Click" />
                </td>
                <td>
                    <asp:Label ID="lblmsg3" runat="server" ForeColor="Red" Text="密码不能为空!" 
                        Visible="False"></asp:Label>
                    <asp:Label ID="lblmsg4" runat="server" ForeColor="Red" Text="密码不一致!" 
                        Visible="False"></asp:Label>
                    <asp:Label ID="lblmsg5" runat="server" ForeColor="Red" Text="密码重置成功!" 
                        Visible="False"
                    ></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
