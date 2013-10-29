<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="adminSeeNoveltyDetail.aspx.cs" Inherits="littleworld.Web.adminNoveltyDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/adminSeeUser.css" rel="stylesheet" type="text/css" />
    <link href="css/adminSeeNovelty.css" rel="stylesheet" type="text/css" />
    <script src="js/adminSeeNovelty.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $(".mainCTitle").html("&nbsp;&nbsp;查看新鲜事详细信息");
            $(".addAdminAlert").hide();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="adminSeeUserDetail">
    <div class="adminSeeUserDetailLeft">
        <div class="userEssentialInformatio">
            <form action="">
                <fieldset class="formTitleFieldset">
                    <legend class="formTitleLegend">基本信息</legend>
                </fieldset>
                <div class="detail">
                    <div class="lableTitle">ID&nbsp：</div>
                    <div class="lableCon"><asp:Label runat="server" ID="labelID"></asp:Label></div>
                </div>
                <div class="detail">
                    <div class="lableTitle">发送人：</div>
                    <div class="lableCon"><asp:Label runat="server" ID="labelSenderName"></asp:Label></div>
                </div>
                <div class="detail">
                    <div class="lableTitle">发布时间：</div>
                    <div class="lableCon"><asp:Label runat="server" ID="labelpublishTime"></asp:Label></div>
                </div>
                <div class="detail">
                    <div class="lableTitle">类&nbsp;型：</div>
                    <div class="lableCon"><asp:Label runat="server" ID="labelType"></asp:Label></div>
                </div>
                <div class="detail">
                    <div class="lableTitle">内&nbsp;容：</div>
                    <div class="lableCon"><asp:Label runat="server" ID="labelContent"></asp:Label></div>
                </div>
                <div class="detail details">
                    <div class="lableTitle">图&nbsp;片：</div>
                    <div class="lableCon noveltyDetailUserImg" runat="server" id="noveltyImgs">
                    </div>
                </div>
            </form> 
        </div>
        <div class="userEssentialInformatio">
            <form action="">
                <fieldset class="formTitleFieldset">
                    <legend class="formTitleLegend">流行度</legend>
                </fieldset>
            </form>
            <div class="detail">
                <div class="lableTitle">评论数：</div>
                <div class="lableCon"><asp:Label runat="server" ID="labelcommentNum"></asp:Label></div>
            </div>
            <div class="detail">
                <div class="lableTitle">赞&nbsp;数：</div>
                <div class="lableCon"><asp:Label runat="server" ID="labelsupportNum"></asp:Label></div>
            </div>
            <div class="detail">
                <div class="lableTitle">转发数：</div>
                <div class="lableCon"><asp:Label runat="server" ID="labeltransmitNum"></asp:Label></div>
            </div>
            <div class="detail">
                <div class="lableTitle">举报数：</div>
                <div class="lableCon"><asp:Label runat="server" ID="labelreportNum"></asp:Label></div>
            </div>
        </div>
    </div>
  
</div>
</asp:Content>
