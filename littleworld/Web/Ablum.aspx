<%@ Page Title="" Language="C#" MasterPageFile="~/userMasterTB.Master" AutoEventWireup="true" CodeBehind="Ablum.aspx.cs" Inherits="littleworld.Web.Ablum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Ablum.css" rel="stylesheet" type="text/css" />
    <script src="js/Jquery-1.9.1.js" type="text/javascript"></script>
    <script src="js/ablum.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="sllcontent">
  <div id="addablumdes">
     <div id="ablum-title"><span id="fl">创建专辑</span><span id="fr"></span></div>
     <div id="editalbum">
        <div id="albumnamebox"><span>专辑名称：</span><input type="text" value="" id="inputname"/><span>0/15</span></div>
        <div id="btnbox"><input type="button" value="确定" id="btnOK"/><input type="button" value="取消" id="btnCancle"/></div>
     </div>
  </div>
  <div id="ablumnav">
     <div id="midnav">
        <div id="logobox"><img src="images/ablumImg/logo_o.png" /></div>
        <div id="navabox">
           <div class="nava">
              <a href="#">相册首页</a>
           </div>
            <div class="nava">
              <a href="#">我的相册</a>
           </div>
            <div class="nava">
              <a href="#">相册广场</a>
           </div>
            <div class="navb">
              <a href="#">上传</a>
           </div>
        </div>
     </div>
     <div id="main">
        <div id="main-title"><span>上传相册</span></div>
        <div id="mainselect">
           <div id="lfm">
              <div id="flspan"><span id="sa">上传至</span></div>
              <div id="flselect">
                  <div id="moren"><span>默认专辑</span></div>
                  <div id="btnshow"></div>
                  <div class="Ablums"><span>生活</span></div>
              </div>
              <div id="createAlum"><span>创建专辑</span></div>
           </div>
        </div>
     
     </div>
  </div>
</div>
</asp:Content>
