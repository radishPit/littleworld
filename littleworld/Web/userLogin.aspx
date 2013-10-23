<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userLogin.aspx.cs" Inherits="littleworld.Web.userLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>用户登陆</title>
     <link href="css/userLogin.css" rel="stylesheet" type="text/css" />
    <script src="js/Jquery-1.9.1.js" type="text/javascript"></script>
    <script src="js/userLogin.js" type="text/javascript"></script>
   
</head>
<body>
    <form id="form1" runat="server">
    <div id="loginWhole">
			<h1 id="TumblrName">
				<a href="#"><img src=""/></a>
			</h1>
			<div id="loginInf" >
				<div id="textEmail">
					<input type="text" onfocus="textInput(1,1);" onblur="textInput(1,2);" id="textEmailT" name="Email" value="Email" class="logintext" />
				</div>
				<div id="textPassword"> 
					<input type="text" onfocus="textInput(2,1);" onblur="textInput(2,2);" value="Password" name="Password" id="textPasswordT" class="logintext" />
				</div>
			</div>
			<a id="loginBtn" href="#" runat="server">
			    <strong>Login in</strong>
			</a>
			<div id="forNew"><a href="userRegister.aspx">sign up for a new account</a></div>
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
