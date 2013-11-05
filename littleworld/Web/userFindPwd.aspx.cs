using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections; 



namespace littleworld.Web
{
    public partial class userFindPwd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSend_Email_Click(object sender, EventArgs e)
        {
            if (this.Txt_Email.Text == "")
            {
                this.Lblsryx.Visible = true;
                this.Lblwzc.Visible = false;
              
            }
            else
            {
                this.Lblsryx.Visible = false;
                BLL.userTb buser = new BLL.userTb();
                List<Model.userTb> lmuser = buser.GetModelList("1=1");
                    int i = 0;
                    for (; i < lmuser.Count; )
                    {

                        if (this.Txt_Email.Text != lmuser[i].userEmail)
                        {
                            i++;
                        }

                        else
                            break;
                    }
                    if (i >= lmuser.Count)
                    {
                        this.Lblwzc.Visible = true;
                    }
                    if (i < lmuser.Count && (Txtyzm.Text == "ym3w" || Txtyzm.Text == "ym3w"))
                    {
                        this.Lblwzc.Visible = false;
                        MailMessage m_message = new MailMessage();

                        m_message.From = new MailAddress("1034834981@qq.com");

                        m_message.To.Add(new MailAddress(this.Txt_Email.Text));

                        m_message.Subject = "LittleWorld";

                        m_message.Body = "邮箱验证信息：http://localhost:3448/userResetPwd.aspx 载入重置密码界面";

                        SmtpClient m_smtpClient = new SmtpClient();

                        m_smtpClient.Send(m_message);
                        
                        Response.Write("<script>alert('验证信息已发送至您邮箱，请进入邮箱验证！');</script>");

                    }
                
                

            }

            if (this.Txtyzm.Text =="")
            {
                this.Lblsryzm.Visible = true;
            }
            else
            {
                this.Lblsryzm.Visible = false;
                if (Txtyzm.Text != "ym3w" || Txtyzm.Text != "ym3w")
                {
                    this.Lblyzm.Visible = true;
                }
                else
                    this.Lblyzm.Visible = false;
;
            }
        }

        protected void Txt_Email_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Txtyzm_TextChanged(object sender, EventArgs e)
        {
            
        }

       
      

        
    }
}