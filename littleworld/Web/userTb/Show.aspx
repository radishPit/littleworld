<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="littleworld.Web.userTb.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		userID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluserID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		userName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluserName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		userEmail
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluserEmail" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		userPwd
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluserPwd" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		headImgUrl
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblheadImgUrl" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sex
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsex" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		addr
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladdr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		age
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblage" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		primarySchool
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblprimarySchool" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		juniorSchool
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbljuniorSchool" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		highSchool
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblhighSchool" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		collegeSchool
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcollegeSchool" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		interstID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblinterstID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		state
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		groupID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblgroupID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		reprotNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblreprotNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		skinID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblskinID" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




