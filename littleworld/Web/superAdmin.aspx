<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="superAdmin.aspx.cs" Inherits="littleworld.Web.superAdmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LittleWorld_superAdmin</title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta name="keywords" content=""/>
	<meta name="description" content=""/>
	<meta name="author" content=""/>
	<link rel="shortcut icon" href="css/images/">
	<link rel="stylesheet" type="text/css" href="css/jquery-ui-1.10.3.custom.min.css">
	<link rel="stylesheet" type="text/css" href="css/superAdmin.css">
	<script type="text/javascript" src="js/Jquery-1.9.1.js"></script>
	<script type="text/javascript" src="js/jquery-ui-1.10.3.custom.min.js"></script>
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
					<li><a class="as"  name="lookAdminInfo">查看管理员信息</a></li>
					<li><a name="AddAdmin">添加管理员</a></li>
				</ul>
			</div>
			<div class="mainContent lookAdminInfo">
				<div class="mainCTitle">管理员信息</div>
				<div class="mainCContent">
					<div class="searchs">
						<div class="searchsL">
							<input id="tags" />
							<button>搜索</button>
						</div>
					</div>
						
					<ul class="mainCContentTb">
						<li class="mainCContentTbLi1">
							<span>账号</span>
							<span>密码</span>
							<span>权限</span>
							<span>修改</span>
							<span>删除</span>
						</li>
						<li class="">
							<span>账号</span>
							<span>密码</span>
							<span>权限</span>
							<span class="sp1"><img src="images/btn_modify.gif"></span>
							<span class="sp2"><img src="images/icon_del.gif"><a>删除</a></span>
						</li>
						<li class="">
							<span>账号</span>
							<span>密码</span>
							<span>权限</span>
							<span class="sp1"><img src="images/btn_modify.gif"></span>
							<span class="sp2"><img src="images/icon_del.gif"><a>删除</a></span>
						</li>
						<li class="">
							<span>账号</span>
							<span>密码</span>
							<span>权限</span>
							<span class="sp1"><img src="images/btn_modify.gif"></span>
							<span class="sp2"><img src="images/icon_del.gif"><a>删除</a></span>
						</li>
					</ul>
				</div>
			</div>
			<div class="mainContent AddAdmin">
				<div class="mainCTitle">添加管理员</div>
				<ul class="addUl">
					<li>
						<label>账&nbsp;&nbsp;&nbsp;&nbsp;号:</label>
						<div class="addDiv">
							<input type="text"/>
							<span>请输入新管理员的账号，请注意唯一性！</span>
						</div>
					</li>
					<li>
						<label>密&nbsp;&nbsp;&nbsp;&nbsp;码:</label>
						<div class="addDiv">
							<input type="text"/>
							<span>6-16位字符，可用数字、字母或符号组合！</span>
						</div>
					</li>
					<li>
						<label>确认密码:</label>
						<div class="addDiv">
							<input type="text"/>
							<span>请再次输入密码，两次密码必须一致！</span>
						</div>
					</li>
					<li>
						<div class="addBtn">添&nbsp;&nbsp;加</div></li>
				</ul>
			</div>
		</div>
	</form>
</body>
</html>
