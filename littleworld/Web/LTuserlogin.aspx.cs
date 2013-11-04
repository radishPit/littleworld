using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace littleworld.Web
{
    public partial class LTuserlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            string id = this.userid.Text.ToString();
            string pwd = this.userpwd.Text.ToString();
            if (id == "" || pwd == "")
            {
                this.falseCause.Text = "*用户名与密码不能为空，请重新输入！";
                return;
            }
           
            BLL.userTb blluser = new BLL.userTb();
            List<Model.userTb> users = blluser.GetModelList("1=1");
            for (int i = 0; i < users.Count; i++)
            {
                if (Convert.ToString(users[i].userID) == this.userid.Text.ToString())
                {
                    Model.userTb userInfo = blluser.GetModel(Convert.ToInt32(id));
                    if (userInfo.userPwd == pwd) { Response.Redirect("LTsection.aspx"); }
                    else
                    {
                        this.falseCause.Text = "*密码错误，请重新输入！";
                        return;
                    }
                }
                else
                {
                    this.falseCause.Text = "*账号不存在，请重新输入！";

                }

            }
        }
    }
}