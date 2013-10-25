<%@ Page Title="" Language="C#" MasterPageFile="~/superAdmin.Master" AutoEventWireup="true" CodeBehind="superSeeAdminInfo.aspx.cs" Inherits="littleworld.Web.superSeeAdminInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/superSeeAdminInfo.css" rel="stylesheet" type="text/css" />
    <script src="js/superSeeAdminInfo.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="mainSee">
        <div class="mainCTitle">&nbsp;&nbsp;查看管理员信息</div> 
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
                    <asp:BoundField DataField="adminID" HeaderText="ID" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="adminName" HeaderText="账号" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="adminPwd" HeaderText="密码" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader" >
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="adminLevel" HeaderText="权限" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="编辑" ShowHeader="False" HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">   
                        <ItemTemplate>
                            <a href="superModifyAdminInfo.aspx?adminIDM=<%# Eval("adminID") %>" class="gvSuperAdminSeeInfoHeaderA" thisAdminID="<%# Eval("adminID") %>"><img src="images/superAdminImg/pencil.png" title="修改<%# Eval("adminID") %>" alt="修改"/></a>
                            <a class="gvSuperAdminSeeInfoHeaderA gvSuperAdminSeeInfoHeaderAD" thisAdminName="<%# Eval("adminName") %>" thisAdminID="<%# Eval("adminID") %>"><img src="images/superAdminImg/cross.png" title="删除<%# Eval("adminID") %>" alt="删除"/></a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                </Columns>
                
            </asp:GridView>
            <div class="paging" runat="server" id="dgvpage"></div>
        </div>
    </div>
    
</asp:Content>
