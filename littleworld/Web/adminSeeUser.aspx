<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="adminSeeUser.aspx.cs" Inherits="littleworld.Web.adminSeeUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/adminSeeUser.css" rel="stylesheet" type="text/css" />
    <script src="js/adminSeeUser.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="adminSeeNovelty">
        <div class="serchAdminInfo">
            <div class="searchsL">
               <%-- <input runat="server" id="tags" class="Searchtags"  />--%>
                <asp:TextBox ID="searchText" CssClass="Searchtags" runat="server"></asp:TextBox>
			    <asp:Button ID="searchBtn" runat="server" Text="搜索" CssClass="searchButton" OnClick="search_Click" />
		    </div>
        </div>
        <div class="mainSeeContent">
            <asp:GridView runat="server" ID="gvSuperAdminSeeInfo" 
                AutoGenerateColumns="False" 
                onrowdatabound="gvSuperAdminSeeInfo_RowDataBound" 
                CssClass="gvSuperAdminSeeInfoCss" >
                <Columns>
                    <asp:BoundField DataField="userID" HeaderText="ID" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="userName" HeaderText="用户名" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="userEmail" HeaderText="邮箱" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader" >
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="addr" HeaderText="地址" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader gvSuperAdminSeeInfoHeaderAddr" >
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader gvSuperAdminSeeInfoHeaderAddr"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="sex" HeaderText="性别" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader" >
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="age" HeaderText="年龄" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader" >
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="collegeSchool" HeaderText="大学"  
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader gvSuperAdminSeeInfoHeaderAddr">
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader gvSuperAdminSeeInfoHeaderAddr"></HeaderStyle>
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="详细" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">
                        <ItemTemplate>
                            <a href="adminUserDetail.aspx?userID=<%# Eval("userID") %>" class="adminNoveltyDetailA">详细...</a>     
                        </ItemTemplate>

<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="操作" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">   
                        <ItemTemplate>
                            <a href="#d" class="adminNoveltyDetailA adminUserFengA" thisUserID="<%# Eval("userID") %>" thisUserState="<%# Eval("state") %>" >封锁</a>
                           <%-- <a href="#d" class="adminNoveltyDetailA adminNoveltyDetailAJieFeng" thisUserID="<%# Eval("userID") %>">解封</a>--%>
                        </ItemTemplate>
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:TemplateField>
                    
                </Columns>
                
            </asp:GridView>
            <div class="paging" runat="server" id="dgvpage"></div>
        </div>
        
    </div>
</asp:Content>
