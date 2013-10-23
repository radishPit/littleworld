using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace littleworld.Web
{
    public partial class superAddAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void addBtn_Click(object sender, EventArgs e)
        {
            string adminName = this.adminName.Text;
            string adminPwd = this.adminPwd.Text;
            string adminPwdA = this.adminPwdAgain.Text;
            if (adminName == "")
            {
                Response.Write("<script language=javascript>alert('请输入新管理员账号！');</" + "script>");
                return;
            }
            if (adminPwd == "" || adminPwdA == "")
            {
                Response.Write("<script language=javascript>alert('密码不能为空！');</" + "script>");
                return;
            }
            if (adminPwd != adminPwdA)
            {
                Response.Write("<script language=javascript>alert('两次输入密码不一致！请重新输入！');</" + "script>");
                return;
            }
            BLL.adminTb admin = new BLL.adminTb();
            List<Model.adminTb> adminLi = admin.GetModelList("adminLevel=1");
            foreach (var adminOne in adminLi)
            {
                if (adminOne.adminName == adminName)
                {
                    Response.Write("<script language=javascript>alert('系统中已经存在该用户');</" + "script>");
                    return;
                }
            }
            Model.adminTb adminMd = new Model.adminTb();
            adminMd.adminName = adminName;
            adminMd.adminPwd = adminPwd;
            adminMd.adminEmail = "无";
            adminMd.adminLevel = 1;
            admin.Add(adminMd);
            this.adminName.Text = "";
            this.adminPwd.Text = "";
            this.adminPwdAgain.Text = "";
        }

    }
}