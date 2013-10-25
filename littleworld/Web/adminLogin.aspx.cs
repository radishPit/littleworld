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

            string no = this.txtQ.Text.ToString();
            string pwd = this.pwdQ.Text.ToString();
            BLL.adminTb blladmin = new BLL.adminTb();
            if (no == "" || pwd == "")
            {
                this.Response.Write("<script language=javascript>alert('用户名与密码不能为空，请重新输入！');</script> ");
                return;
            }

           
            List<Model.adminTb> modadmin = blladmin.GetModelList("adminName='" + no + "'");
            //modadmin = blladmin.GetModel(Convert.ToInt32(no));

            if (modadmin[0].adminPwd  != pwd)
            {
                this.txtQ.Text = "";
                this.pwdQ.Text = "";
                this.Response.Write("<script language=javascript>alert('用户名与密码不匹配，请重新输入！');</script> ");
                ////Response.Write ("用户名与密码不匹配，请重新输入！");
                return;
            }

            Session["no"] = no;
            Session["pwd"] = pwd;
<<<<<<< HEAD

=======
>>>>>>> add supermodifyadminInfo
            if (modadmin[0].adminLevel == 0)
            {
                Response.Redirect("superSeeAdminInfo.aspx");
            }
<<<<<<< HEAD
            else
=======
            else 
>>>>>>> add supermodifyadminInfo
            {
                Response.Redirect("adminModifyInfo.aspx");
            }

<<<<<<< HEAD

=======
>>>>>>> add supermodifyadminInfo
        }









    }
}