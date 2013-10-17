<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="superAdmin.aspx.cs" Inherits="littleworld.Web.superAdmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LittleWorld_superAdmin</title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta name="keywords" content=""/>
	<meta name="description" content=""/>
	<meta name="author" content=""/>
	<link rel="shortcut icon" href=""/>
    <link rel="Stylesheet" type="text/css" href="css/common.css" />
	<link rel="stylesheet" type="text/css" href="css/superAdmin.css"/>   
	<script type="text/javascript" src="js/Jquery-1.9.1.js"></script>
	<script type="text/javascript" src="js/superAdmin.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="topNav">
			<div id="topMain"><label>superAdmin,你好！</label><a href="">退出</a></div>
		</div>
		<div id="mainTop">超级管理员</div>
		<div id="mainNav">
			<ul>
				<li><a href="S" class="as">查看管理员信息</a></li>
				<li><a href="S">添加管理员</a></li>
			</ul>
		</div>
		<div class="lookAdminInfo">
			
		</div>
		<div class="AddAdmin">
			<form action="">
				<div id="loginInf">
					<div id="textEmail">
						<input type="text" onfocus="textInput('textEmailT',1,'');" onblur="textInput('textEmailT',2,'Email');" id="textEmailT" name="Email" value="Email" class="logintext" />
					</div>
					<div id="textPassword"> 
						<input type="text" onfocus="textInput('textPasswordT',1,'');" onblur="textInput('textPasswordT',2,'Password');" name="Password" value="Password" id="textPasswordT" class="logintext" />
					</div>
					<div id="textUserName"> 
						<input type="text" onfocus="textInput('textUserNameT',1,'');" onblur="textInput('textUserNameT',2,'Username');" name="Username" value="Username" id="textUserNameT" class="logintext" />
					</div>
				</div>
				<a id="loginBtn" href="#" >
				    <strong>Sign up</strong>
				</a>
			</form>
		</div>
    </div>
    </form>
</body>
</html>
