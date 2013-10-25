<%@ Page Title="" Language="C#" MasterPageFile="~/superAdmin.Master" AutoEventWireup="true" CodeBehind="superModifyAdminInfo.aspx.cs" Inherits="littleworld.Web.superModifyAdminInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/superAddAdmin.css" rel="stylesheet" type="text/css" />
    <script src="js/superAddAdmin.js" type="text/javascript"></script>
    <script src="js/superModifyAdminInfo.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="AddAdmin">
	    <div class="mainCTitle">&nbsp;&nbsp;修改管理员信息</div> 
        <div class="addAdminAlert">
            <div class="addAdminAlertSuccess addAdminAlert1">
                <div class="addAdminAlertInner"></div>
                <a class="addAdminAlertInnerClose"><img src="images/superAdminImg/cross_grey_small.png" alt="关闭" title="关闭"/></a>
            </div>
            <div class="addAdminAlertFail addAdminAlert1">
                <div class="addAdminAlertInner"></div>
                <a class="addAdminAlertInnerClose"><img src="images/superAdminImg/cross_grey_small.png" alt="关闭" title="关闭"/></a>
            </div>
            <div class="addAdminAlertNotice addAdminAlert1">
                <div class="addAdminAlertInner"></div>
                <a class="addAdminAlertInnerClose"><img src="images/superAdminImg/cross_grey_small.png" alt="关闭" title="关闭"/></a>
            </div>
        </div> 
		<ul class="addUl">
            <li>
				<label>ID&nbsp;&nbsp;&nbsp;&nbsp;号:</label>
				<div class="addDiv">
                    <asp:TextBox type="text" runat="server" ID="adminIDM" ReadOnly="True"></asp:TextBox>
				</div>
			</li>
			<li>
				<label>账&nbsp;&nbsp;&nbsp;&nbsp;号:</label>
				<div class="addDiv">
                    <asp:TextBox type="text" runat="server" ID="adminName"></asp:TextBox>
                    <span>请注意管理员账号的唯一性！</span>
				</div>
			</li>
			<li>
				<label>密&nbsp;&nbsp;&nbsp;&nbsp;码:</label>
				<div class="addDiv">
                    <asp:TextBox type="text" runat="server" ID="adminPwd" ></asp:TextBox>
					<span>6-16位字符，可用数字、字母或符号组合！</span>
				</div>
			</li>
			<li>
				<label>确认密码:</label>
				<div class="addDiv">
                    <asp:TextBox type="text" runat="server" ID="adminPwdAgain" ></asp:TextBox>
					<span>请再次输入密码，两次密码必须一致！</span>
				</div>
			</li>
			<li>
                
                <asp:Button ID="addBtn" runat="server"  Text="修改" class="addBtn" 
                    onclick="modityBtn_Click"/>
                <asp:Button ID="cancelBtn" runat="server" Text="取消" class="addBtn addBtn2" OnClick="cancleBtn_Click"/>
                <%--<input type="reset" value="取消" class="addBtn addBtn2"/>--%>
                <%--<asp:Button ID="cancelBtn" runat="server"  Text="取消" class="addBtn addBtn2" OnClick="cancelBtn_Click"
                />--%>
            </li>
		</ul>
	</div>
</asp:Content>
