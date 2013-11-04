<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="adminSeeEvents.aspx.cs" Inherits="littleworld.Web.adminSeeEvents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style1
    {
            width: 34px;
        }
    .style2
    {
        width: 34px;
        height: 24px;
    }
    .style3
    {
            height: 24px;
        }
        .style4
        {
            width: 34px;
            height: 154px;
        }
        .style5
        {
            height: 154px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    f<table style="width: 92%; height: 338px;">
    <tr>
        <td class="style2">
        </td>
        <td class="style3">
        <div class="searchsL">
                <asp:TextBox ID="searchText" CssClass="Searchtags" runat="server"></asp:TextBox>
			    <asp:Button ID="searchBtn" runat="server" Text="搜索" CssClass="searchButton" 
                    onclick="searchBtn_Click"  />
		    </div>
        </td>
        <td class="style3">
        </td>
    </tr>
    <tr>
        <td class="style4">
            </td>
        <td class="style5">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                
                DataKeyNames="ID" CssClass="gvSuperAdminSeeInfoCss" 
                onrowdatabound="GridView1_RowDataBound" Height="140px">
                <Columns>
      
                    <asp:BoundField DataField="operatorID" HeaderText="角色ID" 
                        SortExpression="operatorID" HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader"/>
                    <asp:BoundField DataField="operateAction" HeaderText="登录角色" 
                        SortExpression="operateAction" HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader"/>
                    <asp:BoundField DataField="operateContent" HeaderText="登录状态" 
                        SortExpression="operateContent" HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader gvSuperAdminSeeInfoHeaderstate"/>
                    <asp:BoundField DataField="operateTime" HeaderText="登录时间" 
                        SortExpression="operateTime" HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader"/>
                </Columns>
            </asp:GridView>
            
        </td>
        <td class="style5">
            </td>
    </tr>
    <tr>
        <td class="style1">
            &nbsp;</td>
        <td>

            <div class="paging" runat="server" id="dgvpage"></div>
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
