<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="adminSeeEventsDetail.aspx.cs" Inherits="littleworld.Web.adminSeeEventsDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<%--<link href="css/adminSeeUser.css" rel="stylesheet" type="text/css" />--%>
    <link href="css/adminSeeEventsDetail.css" rel="stylesheet" type="text/css" />
    <link href="css/adminSeeEvents.css" rel="stylesheet" type="text/css" />
    <script src="js/adminSeeEvents.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $(".mainCTitle").html("&nbsp;&nbsp;查看事务日志详细信息");
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
                 <div class="detailUserImg" id="userImgs" runat="server"><img src=""/></div>
                <div class="detail">
                    <div class="lableTitle">ID&nbsp：</div>
                    <div class="lableCon"><asp:Label runat="server" ID="labelID"></asp:Label></div>
                </div>
                <div class="detail">
                    <div class="lableTitle">用户ID：</div>
                    <div class="lableCon"><asp:Label runat="server" ID="labeloperatorID"></asp:Label></div>
                </div>
                <div class="detail">
                    <div class="lableTitle">操作人&nbsp：</div>
                    <div class="lableCon"><asp:Label runat="server" ID="labelSenderName"></asp:Label></div>
                </div>
                <div class="detail">
                    <div class="lableTitle">操作类型：</div>
                    <div class="lableCon"><asp:Label runat="server" ID="labelType"></asp:Label></div>
                </div>
                <div class="detail">
                    <div class="lableTitle">操作内容：</div>
                    <div class="lableCon"><asp:Label runat="server" ID="labelContent"></asp:Label></div>
                </div>
                <div class="detail">
                    <div class="lableTitle">操作时间：</div>
                    <div class="lableCon"><asp:Label runat="server" ID="labelTime"></asp:Label></div>
                </div>

               
            </form> 
        </div>
        
    </div>
  
</div>
</asp:Content>
