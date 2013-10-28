<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userFindPwd.aspx.cs" Inherits="littleworld.Web.userFindPwd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/userFindPwd.css" rel="stylesheet" type="text/css" />
   
</head>
<body>
    <form id="form1" runat="server">
    <div id="mainpage">
        <div id="email_logo">
        </div>
        <div id="main_title">
            <div id="current">
                <strong>通过登录/注册邮箱找回密码</strong>
            </div>
            <div id="biankuang">
            </div>
        </div>
        <div id="fill-email-div">
            <div class="info_list1">
                <div class="tit">
                    <div class="yx">登录邮箱：</div>
                    <div class="biaozhi"> *</div>
                </div>
                <div class="ipt">
                    <asp:TextBox ID="Txt_Email" maxlength="50" placeholder="请输入登录邮箱" runat="server" 
                        ontextchanged="Txt_Email_TextChanged" > </asp:TextBox>
                    <asp:Label ID="Lblwzc" class="tips" runat="server" Text="未注册该邮箱！" 
                        Visible="False"></asp:Label>
                    <asp:Label ID="Lblsryx" class="tips" runat="server" Text="请输入邮箱！"></asp:Label>
                </div>
                
                
            </div>
            <div class="info_list1">
                <div class="tit">
                    <div class="yx">验证码：</div>
                    <div class="biaozhi"> *</div>
                </div>
                <div class="ipt">
                    
                    <asp:TextBox ID="Txtyzm" class="reg_ipt1" maxlength="4" runat="server" 
                        ontextchanged="Txtyzm_TextChanged"></asp:TextBox>
                    <span class="ver_pic">
                    </span>
                    <asp:Label ID="Lblyzm"  class="tips1" runat="server" Text="验证码不正确！" 
                        Visible="False"></asp:Label>
                    <asp:Label ID="Lblsryzm" class="tips1" runat="server" Text="请输入验证码！"></asp:Label>
                </div>
                
            </div>
            <div class="info_submit">
                
                <asp:Button ID="BtnSend_Email"  runat="server" 
                    Text="发送验证邮件" Height="39px" Width="204px" onclick="BtnSend_Email_Click"  />
            </div>

        </div>

    </div>
    </form>
</body>
</html>
