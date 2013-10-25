<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="adminModifyInfo.aspx.cs" Inherits="littleworld.Web.adminModifyInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="css/adminModifyInfo.css" />
    <script src="js/adminModifyInfo.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mainContent AddAdmin">
		
		<ul class="addUl">
			<li>
				<label>账&nbsp;&nbsp;&nbsp;&nbsp;号:</label>
				<div class="addDiv">
                    <asp:TextBox type="text" runat="server" ID="adminName" ReadOnly="True"></asp:TextBox>
					<span>请输入新管理员的账号，请注意唯一性！</span>
				</div>
			</li>
            <li>
				<label>原密码:</label>
				<div class="addDiv">
                    <asp:TextBox type="text" runat="server" ID="adminOldPwd" TextMode="Password" class="commonText"></asp:TextBox>
					<span>请输入原先的密码！</span>
				</div>
			</li>
			<li>
				<label>新密码:</label>
				<div class="addDiv">
                    <asp:TextBox type="text" runat="server" ID="adminPwd" TextMode="Password"  class="commonText"></asp:TextBox>
					<span>请输入新密码，6-16位字符，可用数字、字母或符号组合！</span>
				</div>
			</li>
			<li>
				<label>确认新密码:</label>
				<div class="addDiv">
                    <asp:TextBox type="text" runat="server" ID="adminPwdAgain" TextMode="Password"  class="commonText"></asp:TextBox>
					<span>请再次输入新密码，两次密码必须一致！</span>
				</div>
			</li>
			<li>
                <asp:Button ID="addBtn" runat="server"  Text="确定" class="addBtn" OnClick="sureBtn_Click"  />
                <asp:Button ID="cancelBtn" runat="server"  Text="取消" class="addBtn addBtn2" OnClick="cancelBtn_Click"/> 
            </li>
		</ul>
	</div>
</asp:Content>
