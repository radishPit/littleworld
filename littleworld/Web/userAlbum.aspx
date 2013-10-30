<%@ Page Title="" Language="C#" MasterPageFile="~/userSpace.Master" AutoEventWireup="true" CodeBehind="userAlbum.aspx.cs" Inherits="littleworld.Web.userAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/userAblum.css" rel="stylesheet" type="text/css" />
    <link href="css/comb_PRF_photo.css" rel="stylesheet" type="text/css" />
    <script src="js/Jquery-1.9.1.js" type="text/javascript"></script>
    <link href="css/jquery-ui-1.10.3.custom.min.css" rel="stylesheet" type="text/css" />
    <script src="js/userSpaceAblum.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div id="box">
      <div id="box-title"><a id="boxtitle-a" href="#">相册专辑</a><span>(共1个)</span><a href="#" id="addablum">上传照片</a></div>
      <div id="box-content">
           <div class="ablumlist">
              <div class="photobox">
                 <div class="a-photobox1"></div>
                 <div class="a-photobox2"><i class="img_box"><img src="images/userAblumImg/status_0.png" alt="相册" /></i></div>
                 <div class="count">共0张</div>
              </div>
              <div class="ablumtitle-box">
                <div class="titlediv"><a href="#" class="skin ablumtitle">默认相册</a></div>
                <div class="updatetime">更新于<span></span></div>
              </div>
           </div>
       </div>
   </div>
</asp:Content>
