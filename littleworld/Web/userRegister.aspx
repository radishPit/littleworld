<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userRegister.aspx.cs" Inherits="littleworld.Web.userRegister" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>用户注册</title>
    <link href="css/userRegister.css" rel="stylesheet" type="text/css" />
    <script src="js/Jquery-1.9.1.js" type="text/javascript"></script>
    <script src="js/userRegister.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
   <div id="loginWhole">
			<h1 id="TumblrName">
				<a href="#"><img src=""/></a>
			</h1>
			<p>Follow the blogs you've been hearing about.<br/>Share the things that you love.</p>
        <div id="style">
			<div id="loginInf">
				<div id="textEmail">
					<asp:TextBox type="text"  id="textEmailT" name1="Email" value="Email" class="logintext" CssClass ="value1 logintext" runat="server" ></asp:TextBox>
				    
				</div> 
				<div id="textPassword"> 
					<asp:TextBox type="text"  name1="Password" value="Password" id="textPasswordT"  
                        CssClass ="value1 logintext" runat="server" TextMode="Password" ></asp:TextBox>

				</div>
				<div id="textUserName"> 
					<asp:TextBox type="text" name1="Username" value="Username" id="textUserNameT"  
                        CssClass ="value1 logintext" runat="server" ></asp:TextBox>
				</div>
                </div>
                 <div id="logincheck">
             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                  ErrorMessage="*邮箱格式不正确" 
                  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                  ControlToValidate="textEmailT" Cssclass="stxt" ForeColor="White"></asp:RegularExpressionValidator>

                     

            </div>
			</div>


           
<%--			<a id="loginBtn" href="#" >
			    <strong>Sign up</strong>
			</a>--%>
            <asp:Button ID="loginBtn"  runat="server" Text="Sign up" 
                  BorderStyle="None" onclick="loginBtn_Click" />


			<div id="forNew"><a href="userLogin.aspx" target="_blank">Log in to dashboard</a></div>
		</div>
		<div id="footer">
			<div id="footerLeft">
				<a href="#" class="foorerA">Terms</a>
				<span>|</span>
				<a href="#" class="foorerA">Privacy</a>
			</div>
			<div id="footerRight">
				<a href="#" class="foorerA foorerAS">Posted by mymodermmet</a>
				<a href="#" class="foorerA"><img src="../images/userRegisterImg/avatar_2b3c1d15ffc8_30.png"/></a>
			</div>
		</div>
    </form>
</body>
</html>
