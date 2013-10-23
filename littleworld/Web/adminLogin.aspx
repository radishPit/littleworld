<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminLogin.aspx.cs" Inherits="littleworld.Web.adminLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理员登陆</title>
    <link href="css/adminLogin.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript">

    </script>
</head>
<body>
    <form id="form1" runat="server">
<div id="screen">
        <div id="screentop">
           <div class="screentab">
             <a href="#" class="top">管理员登陆</a>
           </div> 
<%--           <div class="screentab">
             <a href="#" class="top">超级管理员登陆</a>
           </div>--%>
        </div>

        <div id="screentxt">
          <div id="txtid">
            <span class="zh">账号</span>
            <asp:TextBox ID="txtQ" runat="server" Height="29px"></asp:TextBox>
                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                  ErrorMessage="*账号格式不正确" 
                  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                  ControlToValidate="txtQ"></asp:RegularExpressionValidator>
          </div>
          <div id="txtpwd">
            <span class="zh">密码</span>
            <asp:TextBox type="password" id="pwdQ" runat="server" />
          </div>

          <div id="btn">

 
         
         <%--<a class="top2" href="#">
			   <strong>Login in</strong>
		</a>--%>

              <asp:Button ID="btnOK" class="top2 " runat="server" Text="Login in" 
                  BorderStyle="None" onclick="btnOK_Click"  />

        </div>


   </div>
</div>

    </form>
</body>
</html>
