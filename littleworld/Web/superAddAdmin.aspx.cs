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
            string adminN = this.adminName.Text;
            string adminPwd = this.adminPwd.Text;
            string adminPwdA = this.adminPwdAgain.Text;
            if (adminN == "")
            {
                ScriptManager.RegisterStartupScript(addBtn, this.GetType(), "showErrorAlert", "showErrorAlert('请输入新管理员账号！');", true);
                return;
            }
            if (adminPwd == "" || adminPwdA == "")
            {
                ScriptManager.RegisterStartupScript(addBtn, this.GetType(), "showErrorAlert", "showErrorAlert('密码不能为空！');", true); 
                return;
            }
            if (adminPwd != adminPwdA)
            {
                ScriptManager.RegisterStartupScript(addBtn, this.GetType(), "showErrorAlert", "showErrorAlert('两次输入密码不一致,请重新输入！');", true);
                
                return;
            }
            BLL.adminTb admin = new BLL.adminTb();
            List<Model.adminTb> adminLi = admin.GetModelList("adminLevel=1");
            foreach (var adminOne in adminLi)
            {
                if (adminOne.adminName == adminN)
                {
                    ScriptManager.RegisterStartupScript(addBtn, this.GetType(), "showErrorAlert", "showErrorAlert('系统中已经存在该用户！');", true); 
                    return;
                }
            }
            Model.adminTb adminMd = new Model.adminTb();
            adminMd.adminName = adminN;
            adminMd.adminPwd = adminPwd;
            adminMd.adminEmail = "无";
            adminMd.adminLevel = 1;
            admin.Add(adminMd);
            System.Web.UI.ScriptManager.RegisterStartupScript(addBtn, this.GetType(), "showSuccessAlert", "showSuccessAlert('成功添加该管理员！');", true);
            
            this.adminName.Text = "";
            this.adminPwd.Text = "";
            this.adminPwdAgain.Text = "";
              
        }

    }
}