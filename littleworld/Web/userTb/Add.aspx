<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="littleworld.Web.userTb.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		userName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtuserName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		userEmail
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtuserEmail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		userPwd
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtuserPwd" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		headImgUrl
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtheadImgUrl" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sex
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsex" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		addr
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtaddr" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		age
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtage" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		primarySchool
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtprimarySchool" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		juniorSchool
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtjuniorSchool" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		highSchool
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txthighSchool" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		collegeSchool
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcollegeSchool" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		interstID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtinterstID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		state
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		groupID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgroupID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		reprotNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtreprotNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		skinID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtskinID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
