<%@ Page Title="" Language="C#" MasterPageFile="~/userMasterTB.Master" AutoEventWireup="true" CodeBehind="Ablum.aspx.cs" Inherits="littleworld.Web.Ablum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Ablum.css" rel="stylesheet" type="text/css" />
    <script src="js/Jquery-1.9.1.js" type="text/javascript"></script>
    <script src="js/ablum.js" type="text/javascript"></script>
    <script src="js/uploadify-v2.1.4/jquery-1.4.2.min.js" type="text/javascript"></script>
    <script src="js/uploadify-v2.1.4/jquery.uploadify.v2.1.4.js" type="text/javascript"></script>
    <script src="js/uploadify-v2.1.4/jquery.uploadify.v2.1.4.min.js" type="text/javascript"></script>
    <script src="js/uploadify-v2.1.4/swfobject.js" type="text/javascript"></script>
    <link href="js/uploadify-v2.1.4/uploadify.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        $(document).ready(function () {
            $("#uploadify").uploadify({
                'uploader': 'js/uploadify-v2.1.4/uploadify.swf',
                'script': 'UploadHandler.ashx',
                'cancelImg': 'js/uploadify-v2.1.4/cancel.png',
                'folder': 'UploadFile',
                'queueID': 'fileQueue',
                'auto': false,
                'multi': true
            });
        });  
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="sllcontent">
  <div id="addablumdes">
     <div id="ablum-title"><span id="fl">创建专辑</span><span id="fr"></span></div>
     <div id="editalbum">
        <div id="albumnamebox"><span>专辑名称：</span><input type="text" value="" id="inputname" runat="server" class="iname"/><span id="stringcount">0/15</span></div>
        <div id="showeorr"><span id="errormes" ></span>
            <asp:Label ID="lblnull" runat="server" Text="Label"></asp:Label></div>
        <div id="btnbox"><input type="button" value="确定" id="btnOK" runat="server" onserverclick="btnOK_Click" /><input type="button" value="取消" id="btnCancle" runat="server" onserverclick="btnCancle_Click"/></div>
     </div>
  </div>
  <div id="ablumnav">
     <div id="midnav">
        <div id="logobox"><img src="images/ablumImg/logo_o.png" alt="相册"/></div>
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
                  <div id="moren">
                      <asp:DropDownList ID="selectalbum" runat="server" CssClass="selectone" 
                          onselectedindexchanged="selectalbum_SelectedIndexChanged" 
                          ontextchanged="selectalbum_TextChanged">
                      </asp:DropDownList>
                  </div>
              </div>
              <div id="createAlum"><span>创建专辑</span></div>
           </div>
        </div>
        <div id="upimgbox">
                    <div id="fileQueue"></div>
            <input type="file" name="uploadify" id="uploadify" />
            <p>
              <a href="javascript:$('#uploadify').uploadifyUpload()">上传</a>| 
              <a href="javascript:$('#uploadify').uploadifyClearQueue()">取消上传</a>
            </p>
        </div>
     </div>
  </div>
</div>
</asp:Content>
