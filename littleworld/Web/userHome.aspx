<%@ Page Title="" Language="C#" MasterPageFile="~/userMasterTRB.Master" AutoEventWireup="true"
    CodeBehind="userHome.aspx.cs" Inherits="littleworld.Web.userHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <link href="css/userHome.css" rel="stylesheet" type="text/css" />
    <script src="js/userHome.js" type="text/javascript"></script>
    <script src="This/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="This/jquery.uploadify.js" type="text/javascript"></script>
    <link href="This/uploadify.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
    $(window).load(
    function () {
        $("#<%=FileUpload1.ClientID%>").fileUpload({
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
                                                <a class="fa" href="javascript:$('#<%=FileUpload1.ClientID%>').fileUploadStart()">Start
                                                    Upload</a>&nbsp; <span class="fgt">|</span> &nbsp; <a class="fa" href="javascript:$('#<%=FileUpload1.ClientID%>').fileUploadClearQueue()">
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
            
            </div>
            

        </div>
    </div>
    <div class="Box_right">
        <div class="pl_rightmod_myinfo">
            <div class="W_person_info">
                <div class="headImg">
                    <a href="#" class="headA">
                        <img alt="" src="images/userHomeImg/1.gif" width="80" height="80" />
                    </a>
                </div>
                <div class="nameBox">
                    <a href="#" class="name">用户名 </a>
                </div>
            </div>
            <ul class="user_atten">
                <li><a href="#" class="S_fun"><strong class="stro">6</strong> <span>关注</span> </a>
                </li>
                <li><a href="#" class="S_fun"><strong class="stro">6</strong> <span>粉丝</span> </a>
                </li>
                <li><a href="#" class="S_fun"><strong class="stro">6</strong> <span>微博</span> </a>
                </li>
            </ul>
        </div>
    </div>
</asp:Content>
