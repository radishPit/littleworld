<%@ Page Title="" Language="C#" MasterPageFile="~/userMasterTB.Master" AutoEventWireup="true" CodeBehind="userSpace.aspx.cs" Inherits="littleworld.Web.userSpace" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/userSpace.css" rel="stylesheet" type="text/css" />
    <script src="js/Jquery-1.9.1.js" type="text/javascript"></script>
    <script src="js/userSpace.js" type="text/javascript"></script>
    

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
       <div id="main">
    		<div id="header">
    			<div id="header-top"></div>
    			<div id="header-footer">
    				<div id="headerimage">
                        <div id="headerpic">
                            <asp:Image ID="imghead" runat="server" />
                            <div id="changeimg"><a href="#">更换头像</a></div>
                        </div>
                        <div id="userfan">
                            <a href="#" class="fanc">
                               <asp:Label ID="lblattention" runat="server" Text="Label"></asp:Label><br/>
                                关注
                            </a>
                            <a href="#" class="fanc">
                                <asp:Label ID="lblfans" runat="server" Text="Label"></asp:Label><br/>
                                粉丝
                            </a>
                            <a href="#" class="fanc">
                                <asp:Label ID="lblnews" runat="server" Text="Label"></asp:Label><br/>
                                新鲜事
                            </a>
                        </div>
                    </div>
    				<div id="info">
                        <div id="name">
                            <asp:Label ID="lblname" runat="server" Text="Label"></asp:Label>
                            <asp:Label ID="lblurl" runat="server" Text="Label"></asp:Label>
                        </div>
                        <div id="intruduce"><a href="#">一句话介绍一下自己吧，让别人更了解你</a></div>
                        <div id="tags">
                             
                            <span id="state" runat="server"></span>
                            <span>|</span>
                            <span id="conlege" runat="server"></span>
                            <span>|</span>
                            <asp:Image ID="imgsax" runat="server" />
                        </div>
                        <div id="exit">
                            <asp:Button ID="btnedit" runat="server" Text="编辑个人资料" /></div>
                    </div>
    			</div>
    		</div>
    		<div id="maincontent">
    			<div id="mainnav">
                    <div class="navs" id="nav1">
                        <a href="#" >我的主页</a>
                    </div>
                    <div class="navs" id="nav2">
                        <a href="#">新鲜事</a>
                    </div>
                    <div class="navs" id="nav3">
                        <a href="#">个人资料</a>
                    </div>
                    <div class="navs">
                        <a href="#">相册</a>
                    </div>
                    <div class="navs">
                        <a href="#">赞</a>
                    </div>
                    <div class="navs">
                        <a href="#">足迹</a>
                    </div>
                    <div class="navs">
                        <a href="#">更多</a>
                    </div>
                </div>
    			<div id="child">
                    <div id="select1" class="selectnav">
                        <div class="childl">
                            <div class="content">
                                <div class="content-title">
                                    <a href="#" class="selected">新鲜事<span class="lspan"></span></a>
                                    <span>|</span>
                                    <a href="#">原创</a>
                                    <span>|</span>
                                    <a href="#">图片</a>
                                </div>
                                <div class="mynews">
                                    
                                </div>
                            </div>
                        </div>
                        <div class="childr">
                            <div class="rcontent">
                                <div class="rcontent-title">
                                    <div class="tl">
                                        <a href="#" class="fansclass"><strong>关注/粉丝</strong></a>
                                        <span class="greayw">我的关注和粉丝</span>
                                    </div>
                                </div>
                                <div class="rcfbox">
                                    <div class="minrt">
                                        <a href="#" class="fansclass tl">我的关注</a>
                                        <a href="#" class="redw" id="tr">更多》</a>
                                    </div>
                                    <div class="minrc"></div>
                                    <div class="minrt">
                                        <a href="#" class="fansclass tl">我的粉丝</a>
                                        <a href="#" class="redw tr" >更多》</a>
                                    </div>
                                    <div class="minrc"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div id="select2" class="selectnav">
                       <div class="childl">
                            <div class="content">
                                <div class="content-title">
                                    <a href="#" class="selected">新鲜事<span class="lspan"></span></a>
                                    
                                </div>
                                <div class="mynews">
                                   
                                </div>
                            </div>
                        </div>
                        <div class="childr">
                            <div class="rcontent">
                                <div class="rcontent-title">
                                    <div class="tl">
                                        <a href="#" class="fansclass"><strong>热门微博</strong></a>
                                        
                                    </div>
                                </div>
                                
                                </div>
                            
                        </div>
                    </div>
                    <div id="select3" class="selectnav">
                       <div class="childl">
                            <div class="content">
                                <div class="content-title">
                                    <span class="lspan"><strong>基本信息</strong></span>
                                    <input type="button" class="btnwrite" value="编辑" id="btn1"/>
                                </div>
                                <div class="mynews">
                                   <div class="infotd">
                                        <div class="info-left"><span class="lispan">登录名</span></div>
                                        <div class="info-right"><asp:Label ID="lblloginname" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                        <div class="hidediv"><asp:Label ID="lblh" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                   </div>
                                   <div class="infotd">
                                        <div class="info-left"><span class="lispan">昵称</span></div>
                                        <div class="info-right"><asp:Label ID="lblusername" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                        <div class="hidediv"><input  class="hidetxt" id="username" runat="server"/></div>
                                   </div>
                                   
                                    <div class="infotd">
                                        <div class="info-left"><span class="lispan">所在地</span></div>
                                        <div class="info-right"><asp:Label ID="lbluseraddr" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                        <div class="hidediv"><input type="text" class="hidetxt" id="useraddr" runat="server" runat="server"/></div>
                                   </div>
                                   <div class="infotd">
                                        <div class="info-left"><span class="lispan">性别</span></div>
                                        <div class="info-right"><asp:Label ID="lblusersax" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                        <div class="hidediv"><input type="radio" id="man" runat="server"/>男<input type="radio" id="woman" runat="server"/>女</div>
                                   </div>
                                    <div class="infotd">
                                        <div class="info-left"><span class="lispan">年龄</span></div>
                                        <div class="info-right"><asp:Label ID="lbluserage" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                        <div class="hidediv"><input type="text" class="hidetxt" id="userage" runat="server" /></div>
                                   </div>
                                    <span><strong>教育信息</strong></span>
                                     <div class="infotd">
                                        <div class="info-left"><span class="lispan">小学</span></div>
                                        <div class="info-right"><asp:Label ID="lblprimarySchool" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                        <div class="hidediv"><input type="text" class="hidetxt" id="primarySchool" runat="server" /></div>
                                   </div> 
                                   <div class="infotd">
                                        <div class="info-left"><span class="lispan">初中</span></div>
                                        <div class="info-right"><asp:Label ID="lbljuniorSchool" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                        <div class="hidediv"><input type="text" class="hidetxt" id="juniorSchool" runat="server" /></div>
                                   </div>
                                   <div class="infotd">
                                        <div class="info-left"><span class="lispan">高中</span></div>
                                        <div class="info-right"><asp:Label ID="lblhighSchool" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                        <div class="hidediv"><input type="text" class="hidetxt" id="highSchool" runat="server" /></div>
                                   </div>
                                   <div class="infotd">
                                        <div class="info-left"><span class="lispan">大学</span></div>
                                        <div class="info-right"><asp:Label ID="lblcollegeSchool" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                        <div class="hidediv"><input type="text" class="hidetxt" id="collegeSchool" runat="server" /></div>
                                   </div>
                                    
                                   
                                </div>
                            </div>
                        </div>
                        <div class="childr">
                            <div class="rcontent">
                                <div class="rcontent-title">
                                    <div class="tl">
                                        <a href="#" class="fansclass"><strong>热门微博</strong></a>
                                        
                                    </div>
                                </div>
                                
                                </div>
                            
                        </div>
                    </div>
                </div>
    		</div>
    	</div>
    </div>
</asp:Content>
