using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Media;
using System.IO;

namespace littleworld.Web
{
    public partial class adminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            string no = txtQ.Text.ToString();
            string pwd = this.pwdQ.Text.ToString();
            BLL.adminTb blladmin = new BLL.adminTb();
            Model.adminTb modadmin = new Model.adminTb();
            modadmin = blladmin.GetModel(Convert.ToInt32(no));
            if (modadmin.adminPwd  != pwd)
            {
                Response.Write ("用户名与密码不匹配，请重新输入！");
                return;
            }



        }









    }
}