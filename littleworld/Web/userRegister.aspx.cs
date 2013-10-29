using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace littleworld.Web
{
    public partial class userRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string name = this.textUserNameT.Text.ToString();
            string email = this.textEmailT.Text.ToString();
            string pwd = this.textPasswordT.Text.ToString();
            Session["name"] = name;
            Session["email"] = email;
            Session["pwd"] = pwd;

            Response.Redirect("userInfo.aspx");
            //BLL.userTb blluser = new BLL.userTb();
            //Model.userTb moduser = new Model.userTb();

            //moduser.userName = name;
            //moduser.userEmail = email ;
            //moduser.userPwd = pwd;

            //int i = blluser.Add(moduser);
            //if (i <= 0)
            //{
            //    Response.Write("保存失败，请重新输入！");

            //}
            //Response.Write("保存成功！");

        }

        

        }






    }
