<%@ Page Title="" Language="C#" MasterPageFile="~/userMasterTRB.Master" AutoEventWireup="true" CodeBehind="userComment.aspx.cs" Inherits="littleworld.Web.userComment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="shortcut icon" href="css/images/">
	<link rel="stylesheet" type="text/css" href="css/jquery-ui-1.10.3.custom.min.css">
	<link rel="stylesheet" type="text/css" href="css/userComment.css">
	
	<script type="text/javascript" src="js/jquery-ui-1.10.3.custom.min.js"></script>
	<script type="text/javascript" src="js/userComment.js"></script>
      <div class="W_main_c">   
        <div id="pl_content_commentList">   
            <div class="group_read clearfix">
                <div class="clearfix" style="width:560px;height:32px;">
                    <ul class="sort clearfix">
                        <li class="item current" >
                            <a class="item_link S_func1"  href="#">收到的评论</a>
                            <div class="W_tabarrow_big S_bg4">
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
            <div node-type="myincomment">   
                <div class="big_comment_list">
                    <div class="WB_feed_type msg_box">
                        <dl class="list S_line2 clearfix">
                            <dt class="face">
                                <a href="#">
                                    <img width="50" height="50"src="" ></img>
                                </a>
                            </dt>
                            <dd class="comment">
                                <div class="cm_arr_box S_line1 S_bg1">
                                    <div class="message_arrow">   
                                    </div>
                                </div>
                            </dd>
                        </dl>

                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
