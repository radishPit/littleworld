<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userResetPwd.aspx.cs" Inherits="littleworld.Web.userResetPwd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/userResetPwd.css" rel="stylesheet" type="text/css" />
    <script src="js/Jquery-1.9.1.js" type="text/javascript"></script>
    <script src="js/userResetPwd.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server"> 
    <div id="MIB_bloga">
        <div id="headerblog"></div>
    <div id="MIB_body">
    <div id="main_setupLeft">
    <div id="index_titleT">重置密码:</div>
    <div id="index_titleD">重要提示：每天互联网都会有大量用户的帐号存在着严重被盗的风险。如果你正在使用与其他网站相同的密码，建议你尽快修改。</div>
    
    <div id="curpswC">
    <div id="curpswCL">当前密码:</div>
    <input  type="text" id="curpswCtext" class="txtpswstyle"/>
    <div id="curpswCR">
    <div id="curpswCR1" class="pswCR1style">密码由6—16位半角字符（字母、数字、符号）组成，区分大小写!</div>
      <div id="curpswCR2" class="pswCR2style">密码错误!</div>
    </div>
    </div>

      <div id="newpswC">
    <div id="newpswL">新密码:</div>
            <asp:TextBox ID="newpswCtext" runat="server" class="txtpswstyle"></asp:TextBox>
    <div id="newpswCR">
    <div id="newpswCR1"class="pswCR1style">密码由6—16位半角字符（字母、数字、符号）组成，区分大小写!</div>
         <asp:Label ID="newpswCR2" runat="server" Text="密码不能为空!" Visible="False" 
            class="pswCR2style" BackColor="#CCFF66"  ></asp:Label>

    </div>
    </div>

          <div id="surepswC">
    <div id="surepswL">确认密码:</div>
          <asp:TextBox ID="surepswCtext" runat="server" class="txtpswstyle"></asp:TextBox>
    <div id="surepswCR">
    <div id="surepswCR1" class="pswCR1style">密码由6—16位半角字符（字母、数字、符号）组成，区分大小写!</div>
                    <asp:Label ID="surepswCR2" runat="server" Text="密码不一致!"  class="pswCR2style" BackColor="#CCFF66" 
            Visible="False"></asp:Label>
  
  
    </div>
    </div>

    <div id="submit_password">

        <asp:Button ID="submit_passworda" runat="server" 
            onclick="submit_passworda_Click" Text="确认" />
        </div>

        <div id="lblSuccess">
            <asp:Label ID="lblSuccessC" runat="server"  Text="密码重置成功!" 
                BackColor="Red" Visible="False"  ></asp:Label></div>

    </div>

    <div id="mainsetupRight">
    <div id="mainsetupRighttitle">常见安全问题</div>
    <div class="mainsetupRighttitlestyle1">
    <div class="mainsetupRighttitlestyle2">1.</div>
    <a class="mainsetupRighttitlestyle3" href="#">忘记密码怎么办？</a>
    </div>

        <div class="mainsetupRighttitlestyle1">
    <div class="mainsetupRighttitlestyle2">2.</div>
    <a class="mainsetupRighttitlestyle3" href="#">怎样的密码更安全？</a>
    </div>

        <div class="mainsetupRighttitlestyle1">
    <div class="mainsetupRighttitlestyle2">3.</div>
    <a class="mainsetupRighttitlestyle3" href="#">如何防止帐号被盗？</a>
    </div>

        <div class="mainsetupRighttitlestyle14">
    <div class="mainsetupRighttitlestyle24">4.</div>
    <a class="mainsetupRighttitlestyle34" href="#">修改密码次数过多不能再进行操作怎么办？</a>
    </div>

        <div class="mainsetupRighttitlestyle01">
    <div class="mainsetupRighttitlestyle2">5.</div>
    <a class="mainsetupRighttitlestyle3" href="#">为什么登录微博时提示"您的帐号存在高危风险"</a>
    </div>

    <div id="mainsetupRightD"><div id="mainsetupRightDC">客服电话：4000 960 960（个人） 4000 980 980（企业）按当地市话标准计费</div></div>
    </div>
    </div>
    </div>
       </form>
</body>
</html>
