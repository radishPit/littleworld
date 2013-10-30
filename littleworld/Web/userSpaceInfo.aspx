<%@ Page Title="" Language="C#" MasterPageFile="~/userSpace.Master" AutoEventWireup="true" CodeBehind="userSpaceInfo.aspx.cs" Inherits="littleworld.Web.userSpaceInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/Jquery-1.9.1.js" type="text/javascript"></script>
    <link href="css/userSpaceInfo.css" rel="stylesheet" type="text/css" />
    <script src="js/userSpace.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
   <div id="infobox" >
       <div id="box-left">
              <div id="content">
                                <div class="content-title">
                                   <div class="title-left"><span class="lspan"><strong>基本信息</strong></span></div>
                                    <div id="titleright" runat="server"><input type="button" class="btnwrite" value="编辑" id="btn1"/></div>
                                </div>
                                <div class="mynews">
                                   <div class="infotd">
                                        <div class="info-left"><span class="lispan">登录名</span></div>
                                        <div class="inforight" ><asp:Label ID="lblloginname" runat="server" Text="Label" CssClass="showinfo"></asp:Label></div>
                                        <div id="Div1" class="hidediv" runat="server" ><asp:Label ID="lblh" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                   </div>
                                   <div class="infotd">
                                        <div class="info-left"><span class="lispan">昵称</span></div>
                                        <div class="inforight" ><asp:Label ID="lblusername" runat="server" Text="Label"  class="showinfo"></asp:Label></div>
                                        <div class="hidediv" ><asp:TextBox ID="username" runat="server" CssClass="hidetxt"></asp:TextBox></div>
                                   </div>
                                    <div class="infotd">
                                        <div class="info-left"><span class="lispan">所在地</span></div>
                                        <div class="inforight" ><asp:Label ID="lbluseraddr" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                        <div class="hidediv" ><asp:TextBox ID="useraddr" runat="server" CssClass="hidetxt"></asp:TextBox></div>
                                   </div>
                                   <div class="infotd">
                                        <div class="info-left"><span class="lispan">性别</span></div>
                                        <div class="inforight" ><asp:Label ID="lblusersax" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                        <div class="hidediv" ><input type="radio" id="man" runat="server" class="radio" value="男" name="testradio"/>男<input type="radio" id="woman" runat="server" class="radio" value="女" name="testradio" />女</div>
                                   </div>
                                    <div class="infotd">
                                        <div class="info-left"><span class="lispan">年龄</span></div>
                                        <div class="inforight"><asp:Label ID="lbluserage" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                        <div class="hidediv"><asp:TextBox ID="userage" runat="server" CssClass="hidetxt"></asp:TextBox></div>
                                   </div>
                                     <div class="title-left"><span class="lspan"><strong>基本信息</strong></span></div>
                                     <div class="infotd">
                                        <div class="info-left"><span class="lispan">小学</span></div>
                                        <div class="inforight" ><asp:Label ID="lblprimarySchool" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                        <div class="hidediv" ><asp:TextBox ID="primarySchool" runat="server" CssClass="hidetxt"></asp:TextBox></div>
                                   </div> 
                                   <div class="infotd">
                                        <div class="info-left"><span class="lispan">初中</span></div>
                                        <div class="inforight" ><asp:Label ID="lbljuniorSchool" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                        <div class="hidediv" ><asp:TextBox ID="juniorSchool" runat="server" CssClass="hidetxt"></asp:TextBox></div>
                                   </div>
                                   <div class="infotd">
                                        <div class="info-left"><span class="lispan">高中</span></div>
                                        <div class="inforight"><asp:Label ID="lblhighSchool" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                        <div class="hidediv" ><asp:TextBox ID="highSchool" runat="server" CssClass="hidetxt"></asp:TextBox></div>
                                   </div>
                                   <div class="infotd">
                                        <div class="info-left"><span class="lispan">大学</span></div>
                                        <div class="inforight" ><asp:Label ID="lblcollegeSchool" runat="server" Text="Label" class="showinfo"></asp:Label></div>
                                        <div class="hidediv" ><asp:TextBox ID="collegeSchool" runat="server" CssClass="hidetxt"></asp:TextBox></div>
                                   </div>
                                    
                                </div>
                            </div>
            </div>
                        <div id="box-right">
                            <div class="rcontent">
                                <div class="rcontent-title">
                                    <div class="tl">
                                        <a href="#" class="fansclass"><strong>热门微博</strong></a>
                                    </div>
                                </div>
                            </div>
                        </div>
   
  </div>
</asp:Content>
