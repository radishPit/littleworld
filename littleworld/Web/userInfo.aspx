﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userInfo.aspx.cs" Inherits="littleworld.Web.userInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>用户信息</title>
    <link href="css/userInfo.css" rel="stylesheet" type="text/css" />
    <script src="js/Jquery-1.9.1.js" type="text/javascript"></script>
    <script src="js/userInfo.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="all">
  	<div id="allLeft">
     <div id="txtw5" class="n1">
        <input id="Button1" type="button" cssclass="picd" runat="server" 
            onclick="document.getElementById('FileUpload1').click();" class="picd"  value ="点击上传照片"/>
      <asp:Image ID="Image1" runat="server" Width="120px" 
            ImageUrl="" Height="120px"/>
               <asp:FileUpload ID="FileUpload1" runat="server" Height="30px" Width="160px" 
            BorderStyle="None" style="display:none" />
    <%-- <div id="picd">
                
            <span class="W_btn_upload">
            <i class="W_ico16 icon_upload_upload"></i>
            点击上传照片
        </span>
     </div>--%>
        <br />
 <%--       <asp:FileUpload ID="FileUpload1" runat="server" Height="28px" Width="141px" 
            BorderStyle="None" Visible="False" />--%>
         <asp:Button ID="BtnUpload" runat="server" Text="上传" 
            onclick="BtnUpload_Click" CssClass="btnok" />
  
                <asp:Label ID="LabMessage1" runat="server" ForeColor="white" /><br />
  <%--              <asp:Label ID="LabMessage2" runat="server" />--%>
        <br />
        <br />
  </div>
     
    <div id="txtw6" class="w">
      <span class="zh">兴趣</span>
     <%-- <input type="text" class="txtQ"/>--%>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" 
            Width="150px" >
            <asp:ListItem Value="游泳"></asp:ListItem>
            <asp:ListItem Value="旅游"></asp:ListItem>
            <asp:ListItem Value="登山"></asp:ListItem>
            <asp:ListItem Value="听音乐"></asp:ListItem>
            <asp:ListItem Value="看书"></asp:ListItem>
            <asp:ListItem Value="蹦极"></asp:ListItem>
            <asp:ListItem Value="娱乐八卦"></asp:ListItem>
        </asp:DropDownList>
    </div>
    <div id="txtw7" class="w1">
      <span class="zh">性别</span>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="Rbtnsex" runat="server" Text="男" Checked="True" 
            GroupName="sex" />
        <asp:RadioButton ID="Rbtnsex0" runat="server" Text="女" GroupName="sex" />
    </div>
    <div id="txtw8" class="w1">
      <span class="zh">年龄</span>
      <asp:TextBox type="text" class="txtQ1" ID="txtage"  runat="server"></asp:TextBox>
    </div>

   </div>
  <div id="allRight">

  <%--<div id="txtw" class="n">
       <span class="zh">昵称</span>
       <input type="text" class="txtQ"/>
     </div>--%>
    <div id="txtw0" class="n1">
      <span class="zh">现居地</span>
      <asp:TextBox type="text" class="txtQu" id="txtaddr"  runat="server" >
       </asp:TextBox>
&nbsp;</div>
    <div id="txtw1" class="w">
      <span class="zh">小学</span>
      <asp:TextBox type="text" class="txtQ" id="txtpri"  runat="server" > </asp:TextBox>
    </div>
    <div id="txtw2" class="w">
      <span class="zh">初中</span>
      <asp:TextBox type="text" class="txtQ" id="txtmid"  runat="server" > </asp:TextBox>
    </div>
    <div id="txtw3" class="w">
      <span class="zh">高中</span>
      <asp:TextBox type="text" class="txtQ" id="txtsenior"  runat="server" > </asp:TextBox>
    </div>
    <div id="txtw4" class="w">
      <span class="zh">大学</span>
      <asp:TextBox type="text" class="txtQ" id="txtcol"  runat="server" > </asp:TextBox>
    </div>
	
  </div>
	
         
	
        
	
         
	
  </div>


    <div id="btn">
     <asp:Button ID="btnOK" class="top2 " runat="server" Text="保存" 
                  BorderStyle="None" onclick="btnOK_Click"   />
        <%-- <a href="#" class="top2">
	          保存
	        </a>--%>
    </div>
    </form>
</body>
</html>
