using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace littleworld.Web
{
    public partial class superModifyAdminInfo : System.Web.UI.Page
    {
        string oldName;
        string oldPwd;
        BLL.adminTb blladminM = new BLL.adminTb();
        Model.adminTb adminM = new Model.adminTb();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["adminIDM"] == null)
            {
                ScriptManager.RegisterStartupScript(addBtn, this.GetType(), "showErrorAlert", "showErrorAlert('页面加载错误！');", true);     
            }
            int adminIDMo =System.Int32.Parse(Request.QueryString["adminIDM"]);
            adminM = blladminM.GetModel(adminIDMo);
            if (adminM==null)
            {
                ScriptManager.RegisterStartupScript(addBtn, this.GetType(), "showErrorAlert", "showErrorAlert('无该管理员信息！');", true);
            }
            
            oldName = adminM.adminName;
            oldPwd = adminM.adminPwd;
            this.adminIDM.Text = adminIDMo.ToString();
            //this.adminName.Text = oldName;
            //this.adminPwd.Text = oldPwd;
            //this.adminPwdAgain.Text = oldPwd;
        }
        protected void modityBtn_Click(object sender,EventArgs e) 
        {
            string adminN = this.adminName.Text;
            //Response.Write("<script language=javascript>alert(" + adminN + ");</" + "script>");
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
            adminM.adminName = adminN;
            adminM.adminPwd = adminPwd;
            admin.Update(adminM);
            System.Web.UI.ScriptManager.RegisterStartupScript(addBtn, this.GetType(), "showSuccessAlert", "showSuccessAlert('成功修改该管理员信息，3秒钟后将跳转到查看管理员信息页面！');", true);
            
            //System.Threading.Thread.Sleep(3000);
            //Response.Redirect("superSeeAdminInfo.aspx");

        }
        protected void cancleBtn_Click(object sender, EventArgs e)
        {
            System.Web.UI.ScriptManager.RegisterStartupScript(addBtn, this.GetType(), "showNoticeAlert", "showNoticeAlert('您取消了修改该管理员的信息！');", true);
            this.adminName.Text = oldName;
            this.adminPwd.Text = oldPwd;
            this.adminPwdAgain.Text = oldPwd;
        }
    }
}