using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace littleworld.Web
{
    public partial class userLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string email = this.textEmailT.Text.ToString();
            string pwd = this.textPasswordT.Text.ToString();
            BLL.userTb blluser = new BLL.userTb();
            if (email == "" || pwd == "")
            {
                this.Response.Write("<script language=javascript>alert('邮箱与密码不能为空，请重新输入！');</script> ");
                return;
            }


            List<Model.userTb> moduser = blluser.GetModelList("userEmail='" + email + "'");

            if (moduser[0].userPwd != pwd)
            {
                this.textEmailT.Text = "";
                this.textPasswordT.Text = "";
                this.Response.Write("<script language=javascript>alert('邮箱与密码不匹配，请重新输入！');</script> ");
                ////Response.Write ("用户名与密码不匹配，请重新输入！");
                return;
            }

            Session["no"] = email;
            Session["pwd"] = pwd;

            Response.Redirect("userHome.aspx");
          
        }
    }
}