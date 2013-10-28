<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="adminSeeUserDetail.aspx.cs" Inherits="littleworld.Web.adminUserDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/adminSeeUser.css" rel="stylesheet" type="text/css" />
    <script src="js/adminSeeUser.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $(".mainCTitle").html("&nbsp;&nbsp;查看用户详细信息");
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
            </form>
            <div class="detailUserImg" id="userImgs" runat="server"><img src=""/></div>
            <div class="detail">
                <div class="lableTitle">ID&nbsp;号：</div>
                <div class="lableCon"><asp:Label runat="server" ID="labelID">dsfad</asp:Label></div>
            </div>
            <div class="detail">
                <div class="lableTitle">用户名：</div>
                <div class="lableCon"><asp:Label runat="server" ID="labelUserName"></asp:Label></div>
            </div>
            <div class="detail">
                <div class="lableTitle">密&nbsp;码：</div>
                <div class="lableCon"><asp:Label runat="server" ID="labelUserPwd"></asp:Label></div>
            </div>
          
            <div class="detail">
                <div class="lableTitle">性&nbsp;别：</div>
                <div class="lableCon"><asp:Label runat="server" ID="labelSex"></asp:Label></div>
            </div>
            <div class="detail">
                <div class="lableTitle">年&nbsp;龄：</div>
                <div class="lableCon"><asp:Label runat="server" ID="labelAge"></asp:Label></div>
            </div>
            <div class="detail">
                <div class="lableTitle">住&nbsp;址：</div>
                <div class="lableCon"><asp:Label runat="server" ID="labelAddr"></asp:Label></div>
            </div>
        </div>
        <div class="userEssentialInformatio">
            <form action="">
                <fieldset class="formTitleFieldset">
                    <legend class="formTitleLegend">联系方式</legend>
                </fieldset>
            </form>
            <div class="detail">
                <div class="lableTitle">E-mail：</div>
                <div class="lableCon"><asp:Label runat="server" ID="labelUserEmail"></asp:Label></div>
            </div>
        </div>
        <div class="userEssentialInformatio">
            <form action="">
                <fieldset class="formTitleFieldset">
                    <legend class="formTitleLegend">教育背景</legend>
                </fieldset>
            </form>
            <div class="detail">
                <div class="lableTitle">小&nbsp;学：</div>
                <div class="lableCon"><asp:Label runat="server" ID="labelUserPrimarySchool"></asp:Label></div>
            </div>
            <div class="detail">
                <div class="lableTitle">初&nbsp;中：</div>
                <div class="lableCon"><asp:Label runat="server" ID="labelUserJuniorSchool"></asp:Label></div>
            </div>
            <div class="detail">
                <div class="lableTitle">高&nbsp;中：</div>
                <div class="lableCon"><asp:Label runat="server" ID="labelUserHighSchool"></asp:Label></div>
            </div>
            <div class="detail">
                <div class="lableTitle">大&nbsp;学：</div>
                <div class="lableCon"><asp:Label runat="server" ID="labelUserCollegeSchool"></asp:Label></div>
            </div>
        </div>
        <div class="userEssentialInformatio">
            <form action="">
                <fieldset class="formTitleFieldset">
                    <legend class="formTitleLegend">兴趣爱好</legend>
                </fieldset>
            </form>
            <div class="detail">
                <div class="lableTitle">兴&nbsp;趣：</div>
                <div class="lableCon"><asp:Label runat="server" ID="labelUserInterest"></asp:Label></div>
            </div>
        </div>
        
    </div>
  
</div>


</asp:Content>
