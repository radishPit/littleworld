<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminLogin.aspx.cs" Inherits="littleworld.Web.adminLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理员登陆</title>
    <link href="css/adminLogin.css" rel="stylesheet" type="text/css" />
    <script src="js/Jquery-1.9.1.js" type="text/javascript"></script>
    <script type="text/javascript" src="js/adminLogin.js"></script>

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
            <asp:TextBox id="txtQ" name1="账号" value="账号" class="logintext" CssClass ="value1 logintext" runat="server" Height="29px"></asp:TextBox>
                <%--&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                  ErrorMessage="*账号格式不正确" 
                  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                  ControlToValidate="txtQ" ForeColor="#336600"></asp:RegularExpressionValidator>--%>
          </div>
          <div id="txtpwd">
            <asp:TextBox type="password" id="pwdQ" name1="密码" value="密码"  CssClass ="value1 logintext" runat="server" />
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
