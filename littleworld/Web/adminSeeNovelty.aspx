<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="adminSeeNovelty.aspx.cs" Inherits="littleworld.Web.adminSeeNovelty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/adminSeeNovelty.css" rel="stylesheet" type="text/css" />
    <script src="js/adminSeeNovelty.js" type="text/javascript"></script>
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
                    <asp:BoundField DataField="noveltyID" HeaderText="ID" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="senderID" HeaderText="发送人" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="内容" HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">
                        <ItemTemplate>
                            <a href="adminNoveltyDetail.aspx?noveltyID=<%# Eval("noveltyID") %>" class="adminNoveltyDetailA">详细...</a>     
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="commentNum" HeaderText="评论数" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader" >
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="supportNum" HeaderText="赞数" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader" >
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="reportNum" HeaderText="举报数" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader" >
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="transmitNum" HeaderText="转发数" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader" >
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="publishtime" HeaderText="发布时间"  
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="hasImgs" HeaderText="是否有图片" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="屏蔽" 
                        HeaderStyle-CssClass="gvSuperAdminSeeInfoHeader">   
                        <ItemTemplate>
                            <a class="gvSuperAdminSeeInfoHeaderA" thisNoveltyID="<%# Eval("noveltyID") %>"><img src="images/superAdminImg/cross.png" title="删除<%# Eval("noveltyID") %>" alt="删除"/></a>
                        </ItemTemplate>
<HeaderStyle CssClass="gvSuperAdminSeeInfoHeader"></HeaderStyle>
                    </asp:TemplateField>
                    
                </Columns>
                
            </asp:GridView>
            <div class="paging" runat="server" id="dgvpage"></div>
        </div>
        
    </div>

</asp:Content>
