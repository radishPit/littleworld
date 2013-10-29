<%@ Page Title="" Language="C#" MasterPageFile="~/userMasterTRB.Master" AutoEventWireup="true" CodeBehind="userMassage.aspx.cs" Inherits="littleworld.Web.userMassage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    	<link rel="shortcut icon" href="css/images/">
	<link rel="stylesheet" type="text/css" href="css/jquery-ui-1.10.3.custom.min.css">
	<link rel="stylesheet" type="text/css" href="css/userMassage.css">
	<script type="text/javascript" src="js/Jquery-1.9.1.js"></script>
	<script type="text/javascript" src="js/jquery-ui-1.10.3.custom.min.js"></script>
	<script type="text/javascript" src="js/userMassage.js"></script>
  <div class="W_main_c">   
        <div id="pl_content_box">   
            <div class="group_read">   
                <div class="title">
                消息
                </div>
            </div>
            <div class="tab_normal clearfix">
                <div class="tab_normal_l">
                    <a class="W_btn_b send_msg_btn" href="#">
                        <span>
                            <em class="icon_mes"></em>
                            发私信
                        </span>
                    </a>
                    <a class="W_btn_b" href="#">
                        <span>
                            全部设置为已读
                        </span>
                    </a>
                </div>
                <div class="tab_normal_r">
                    <i class="W_ico16 icon_lock"></i>
                    <em class="S_txt2">消息箱隐私设置</em>
                    <a class="func_setup S_link1" href="#">设置</a>
                </div>
            </div>
            <div id="all_msg_list">  
               
            </div>
        </div>
    </div>
</asp:Content>
