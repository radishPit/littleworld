<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LTuserlogin.aspx.cs" Inherits="littleworld.Web.LTuserlogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>新鲜事论坛</title>
    <meta name="keywords" content="kw1,kw2,kw3"/>
	<meta name="description" content="This is it."/>
	<meta name="author" content="GX"/>
    <link rel="shortcut icon" href="images/LTsection/spotify_variation.ico"/>
    <link href="css/LTuserlogin.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="totalpage">
   	  <div id="loginpage">
   	  	<div id="wrappertop"></div>
   	  	<div id="wrapper">
   	  		<div id="content">
   	  			<div id="header">
                  <img id="logo1" src="images/LTuserloginImg/drawingpin2_blue.png"/>
	   	  		  <img id="logo" src="images/LTuserloginImg/LoginLOGO.png"/>
   	  			</div>
   	  			<div id="clogo">
   	  				<div id="clogin">Login</div>
   	  			</div>
   	  			<div id="leftwrap"></div>
   	  			<div id="loginform">
   	  				<div id="lusername">
   	  					<p class="lun1">账号:</p>
                        <asp:TextBox ID="userid" runat="server" CssClass="txtQuery"></asp:TextBox>
<%--   	  					<input type="text" class="txtQuery">--%>
   	  				</div>
   	  				<div id="luserpsw">
   	  					<p class="lun1">密码:</p>
                        <asp:TextBox ID="userpwd" runat="server" CssClass="txtQuery" type="password"></asp:TextBox>
<%--   	  					<input type="text" class="txtQuery">--%>
   	  				</div>
   	  				<div id="btnlogin">
   	  				   <%--<div id="btnImg"></div>
   	  				   登录--%>
                       <asp:Button runat="server" Text="登录"  CssClass="loginbtn" ID="btnOK" 
                            BorderStyle="Outset" onclick="btnOK_Click"/>
   	  			    </div>
   	  				<div id="fgt">|</div>
   	  				<a href="userRegister.aspx" target="_blank"id="forgotword">注册</a>
   	  			</div>		
   	  		</div>
            
   	  	</div>
   	  	<div id="wrapperbottom">
   	  		<div id="bottomword">
            <asp:Label ID="falseCause" runat="server" Text="" ForeColor="Red"> By Freelance Suite.Project, Client & Billing management</asp:Label>
               
   	  		 </div>
   	  	</div>
   	  </div>
   </div>
    </form>
</body>
</html>
