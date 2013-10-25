<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userReport.aspx.cs" Inherits="littleworld.Web.userReport" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>userReport</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta name="keywords" content=""/>
	<meta name="description" content=""/>
	<meta name="author" content=""/>
	<link rel="shortcut icon" href="css/images/">
	<link rel="stylesheet" type="text/css" href="css/jquery-ui-1.10.3.custom.min.css">
	<link rel="stylesheet" type="text/css" href="css/userReport.css">
	<script type="text/javascript" src="js/Jquery-1.9.1.js"></script>
	<script type="text/javascript" src="js/jquery-ui-1.10.3.custom.min.js"></script>
	<script type="text/javascript" src="js/userReport.js"></script>
</head>
<body>
   <div id="pl_report_feed" class="cp_container clearfix">
       <div class="cp_paper clearfix">
            <!-头部->
           <div class="cp_paper_head clearfix">
               <div class="cp_txt_to">
               我要举报的是“
               <a  class="cp_link_blue" href="/"><% = userName%></a>
               ”发的微博
               </div>
               <div class="cp_wb_short" node-type="abstract">
                    <dl>
                        <dt>
                            <a  id="userimg" href="/">
                                <img src="<% =headImgUrl %>" alt="Alternate Text" style="width:30px;height:30px;"></img>
                            </a>
                        </dt>
                        <dd>
                             <a class="cp_link_blue" href="/"><% = userName%></a>
                             ：<% = contents%>
                        </dd>
                    </dl>
                </div>
               <div class="cp_radiobox clearfix" node-type="radiobox">
                   <span class="radiobox_tit">请选择举报类型：</span>
                   <div class="radiobox" node-type="leftBox">
                       <p>
                           <input id="11" class="W_radio" type="radio" value="11" action-type="switch" name="radio_bad"></input>
                           <label class="cholab" tip-txt="买卖粉丝、机器发广告、刷评论转发等内容" for="11">垃圾广告
                            </label>
                       </p>
                        <p>
                           <input id="12" class="W_radio" type="radio" value="12" action-type="switch" name="radio_bad"></input>
                           <label class="cholab" for="12">虚假中奖
                            </label>
                       </p>
                        <p>
                           <input id="13" class="W_radio" type="radio" value="13" action-type="switch" name="radio_bad"></input>
                           <label class="cholab" tip-txt="信息虚假、夸张、配图不符、过期、残缺等" for="13">不实信息
                            </label>
                       </p>
                       <p>
                           <input id="14" class="W_radio" type="radio" value="14" action-type="switch" name="radio_bad"></input>
                           <label class="cholab" for="14">敏感信息
                            </label>
                       </p>
                        <p>
                           <input id="15" class="W_radio" type="radio" value="15" action-type="switch" name="radio_bad"></input>
                           <label class="cholab" for="15">淫秽色情
                            </label>
                       </p>
                   </div>
                    <div class="radiobox" node-type="rightBox">
                       <p>
                           <input id="21" class="W_radio" type="radio" value="21" action-type="switch" name="radio_bad"></input>
                           <label class="cholab" for="21">人身攻击我
                            </label>
                       </p>
                        <p>
                           <input id="22" class="W_radio" type="radio" value="22" action-type="switch" name="radio_bad"></input>
                           <label class="cholab" for="22">骚扰我
                            </label>
                       </p>
                        <p>
                           <input id="23" class="W_radio" type="radio" value="23" action-type="switch" name="radio_bad"></input>
                           <label class="cholab" for="23">冒充我
                            </label>
                       </p>
                       <p>
                           <input id="24" class="W_radio" type="radio" value="24 action-type="switch" name="radio_bad"></input>
                           <label class="cholab" for="24">抄袭我的内容
                            </label>
                       </p>
                        <p>
                           <input id="25" class="W_radio" type="radio" value="25" action-type="switch" name="radio_bad"></input>
                           <label class="cholab" for="25">泄露我的隐私
                            </label>
                       </p>
                   </div>
               </div>
           </div>
           <div class="cp_paper_body clearfix">    
                <div class="cp_btnbox" title="选择正确的举报类别可增加举报处理的速度" >
                    <a class="cp_btn_sub">
                        提交
                    </a>
                </div>
           </div>
           <div class="cp_paper_bottom clearfix">
               <div class="cp_footbox">
                举报电话:188 6248 2652（个人） 188 6248 2750（企业）
               </div>
           </div>
      </div>     
   </div>
    <div class="logoimg">
        <a class="logo" href="/"></a>
    </div>
</body>
</html>
