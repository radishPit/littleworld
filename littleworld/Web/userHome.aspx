<%@ Page Title="" Language="C#" MasterPageFile="~/userMasterTRB.Master" AutoEventWireup="true"
    CodeBehind="userHome.aspx.cs" Inherits="littleworld.Web.userHome" %>
<%@ Reference Page="~/userLogin.aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <link href="css/userHome.css" rel="stylesheet" type="text/css" />
    <script src="js/userHome.js" type="text/javascript"></script>
   <%-- <script src="This/jquery-1.3.2.min.js" type="text/javascript"></script>--%>
   
    <script src="This/jquery.uploadify.js" type="text/javascript"></script>
    <link href="This/uploadify.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
//        var $j = $.noConflict(true);
        $j(window).load(
    function () {
        $j("#<%=FileUpload1.ClientID%>").fileUpload({
            'uploader': 'This/uploader.swf',
            'cancelImg': 'This/images/cancel.png',
            'buttonText': 'Browse Files',
            'script': 'This/Upload.ashx',
            'folder': 'UploadImg/noveltyImages',
            'fileDesc': 'Image Files',
            'fileExt': '*.jpg;*.jpeg;*.gif;*.png',
            'multi': true,
            'auto': false,
            onComplete: function (a, b, c, d, e) {
               
                $("#news_container").append('<img src="This/' + d + '/" width="80" height="80" class="unique">');
            }
        });
    }
);
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="testp"></p>
    <div class="Box_center">
        <div class="pl_content_publisherTop">
            <div class="send_weibo">
                <div class="title_area ">
                    <div class="title">
                    </div>
                </div>
                <div class="input">
                    <textarea id="txtarea" class="input_detail" runat="server" cols="38" rows="4"></textarea>
                    <span class="arrow"></span>
                </div>
                <div class="func_area">
                    <div class="func">
                        <a href="#" class="send_btn"><span class="btn_30px">发布 </span></a>
                    </div>
                    <div class="dingwei">
                        <a href="#" class="uploadImg"><span class="icon_sw_img"></span>图片 </a>
                        <div class="W_layer">
                            <div class="bg">
                                <div class="content">
                                    <div class="antitle">
                                        本地上传 <a href="javascript:void(0)" class="W_close"></a>
                                    </div>
                                    <div class="layer_pic_list">
                                        <div class="pic_list_count">
                                            <div class="num">
                                                共1张，还能上传8张
                                            </div>
                                            <p class="ctrla">
                                                （按住ctrl可选择多张）
                                            </p>
                                        </div>
                                        <div class="pic_list">
                                            <div id="test">
                                            </div>
                                            <div class="w">
                                                <a class="fa" href="javascript:$j('#<%=FileUpload1.ClientID%>').fileUploadStart()">Start
                                                    Upload</a>&nbsp; <span class="fgt">|</span> &nbsp; <a class="fa" href="javascript:$j('#<%=FileUpload1.ClientID%>').fileUploadClearQueue()">
                                                        Clear</a>
                                                <div style="padding: 40px">
                                                    <asp:FileUpload ID="FileUpload1" runat="server" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="pl_content_homeFeed">
            <div class="group_read" >
                <div class="bar">
                    <div class="sort">
                        <span class="current"><a href="#" class="curA">微博</a> <span class="curbg"></span>
                        </span>
                    </div>
                </div>
            </div>
            <div id="news_container">


<%--<div class='top_div'></div><div class='mid_div'><div class='mid_con'><div class='mid_con_bar'><div class='inner'><a href='#' class='innera'>何炅</a>(<a href='#' class='innera'>昵称</a>)</div><div class='inner'><a href='#' class='innera'>关注<span>11</span></a><a href='#' class='innera'>粉丝<span>1212</span></a><a href='#' class='innera'>微博<span>1212</span></a></div></div><div class='mid_sec'><div class='mid_sec_con'><a href='#' class='innera'>地址</a><span class='sfgt '>|</span><span class='innera black'>毕业学校：</span><a href='#' class='innera'>学校名称</a></div></div></div></div><div class='bottom_div'><div class='bot_inner'><a href='javascript:void(0)' class='innera'>个人主页</a><span class='sfgt'>|</span><a href='javascript:void(0)' class='innera'>微博</a><span class='sfgt'>|</span><a href='javascript:void(0)' class='innera'>个人资料</a><span class='sfgt'>|</span><a href='javascript:void(0)' class='innera'>相册</a><span class='sfgt'>|</span><a href='javascript:void(0)' class='innera'>赞</a><span class='sfgt'>|</span><a href='javascript:void(0)' class='innera'>…</a></div></div><div class='headImg'><img src="" width="86" height="86"></div>
--%>



<%--<div class='WB_media_expand'><div class='WB_arrow'><em class='S_line1_c'>◆</em><span class='S_bg1_c'>◆</span></div><div node-type='feed_list_forwardContent'><div class='WB_info'><a href='#' class='WB_name'>daxifua</a></div><div class='WB_text'>zdfdfgadga</div><div class='WB_func'><div class='WB_func'><div class='WB_handle'><a href='javascript:void(0)' class='zan'><em class='icon_praised_b'></em>(1299)</a><i class='sfgt ch'>|</i><a href='javascript:void(0)' class='zan'>转发(1443)</a><i class='sfgt ch'>|</i><a href='javascript:void(0)' class='zan'>收藏</a><i class='sfgt ch'>|</i><a href='javascript:void(0)' class='zan'>评论(1443)</a></div><div class='WB_from'><a href='' class='WB_time'>10月24日 22:37</a></div></div></div></div>
--%>























            </div>
            

        </div>
    </div>
    <div class="Box_right">
        <div class="pl_rightmod_myinfo">
            <div class="W_person_info">
                <div class="headImg">
                    <a href="userSpace.aspx" class="headA">
                        <img alt="" runat="server"  id="myImg" onclick="myImg_Click()" src="images/userHomeImg/1.gif" width="80" height="80" />
                    </a>
                </div>
                <div class="nameBox">
                    <a href="#" class="name" runat="server" id="myname"></a>
                   
                    <a href="" id="<%=MyID%>"  class="FindID"></a>
                </div>
            </div>
            <ul class="user_atten">
                <li><a href="#" class="S_fun"><strong class="stro" runat="server" id="guanzhunum"></strong> <span>关注</span> </a>
                </li>
                <li><a href="#" class="S_fun"><strong class="stro" runat="server" id="fansnum"></strong> <span>粉丝</span> </a>
                </li>
                <li><a href="#" class="S_fun"><strong class="stro" runat="server" id="noveltynum"></strong> <span>新鲜事</span> </a>
                </li>
            </ul>
        </div>
    </div>
</asp:Content>
