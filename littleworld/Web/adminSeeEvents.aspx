<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="adminSeeEvents.aspx.cs" Inherits="littleworld.Web.adminSeeEvents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/adminSeeEvents.css" rel="stylesheet" type="text/css" />
    <script src="js/adminSeeEvents.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="adminSeeNovelty">
        <div class="serchAdminInfo">
            <div class="searchsL">
              
                <asp:TextBox ID="searchText" CssClass="Searchtags" runat="server"></asp:TextBox>
			    <asp:Button ID="searchBtn" runat="server" Text="搜索" CssClass="searchButton" OnClick="search_Click" />
		    </div>
        </div>
        <div class="mainSeeContent">
            <asp:GridView runat="server" ID="gvSuperAdminSeeInfo" 
                AutoGenerateColumns="False" 
                onrowdatabound="gvSuperAdminSeeInfo_RowDataBound" 
                CssClass="gvSuperAdminSeeInfoHeaderAddr" 
                onselectedindexchanged="gvSuperAdminSeeInfo_SelectedIndexChanged" 
                Width="347px" >
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">
            <HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="操作人" HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">
                        <ItemTemplate>
                            <a href="adminSeeUserDetail.aspx?userID=<%# Eval("operatorID") %>" class="adminNoveltyDetailA adminUserFengA" ><%# showSenderName(Eval("operatorID").ToString())%></a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="内容" HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">
                        <ItemTemplate>
                            <a href="adminSeeEventsDetail.aspx?EventsID=<%# Eval("ID") %>" class="adminNoveltyDetailA">详细...</a>     
                        </ItemTemplate>
                        <HeaderStyle CssClass="gvSuperAdminSeeInfoHeader" />
                    </asp:TemplateField>
                </Columns>
                
            </asp:GridView>
            <div class="paging" runat="server" id="dgvpage"></div>
        </div>
        
    </div>
</asp:Content>
