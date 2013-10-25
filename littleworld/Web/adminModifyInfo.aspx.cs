using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace littleworld.Web
{
    public partial class adminModifyInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string adName;
        string mainTitle;
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            adName = (Master.FindControl("adminNamel") as Label).Text;
            this.adminName.Text = adName;
            
        }
        protected void sureBtn_Click(object sender, EventArgs e)
        {
            string adminN = this.adminName.Text;
            string adminOldP = this.adminOldPwd.Text;
            string adminNewP = this.adminPwd.Text;
            string adminNewPA = this.adminPwdAgain.Text;
            BLL.adminTb adminBll = new BLL.adminTb();
            List<Model.adminTb> adminM = adminBll.GetModelList("adminLevel=1 and adminName='"+adminN+"'");
            foreach (var adminOne in adminM)
            {
                if (adminNewP=="" || adminNewPA=="")
                {
                    //Response.Write("<script language=javascript>alert('新密码不能为空！');</" + "script>");
                    ScriptManager.RegisterStartupScript(addBtn, this.GetType(), "showErrorAlert", "showErrorAlert('新密码不能为空！');", true);
                    return;
                }
                if (adminOldP!=adminOne.adminPwd)
                {
                    ScriptManager.RegisterStartupScript(addBtn, this.GetType(), "showErrorAlert", "showErrorAlert('您输入的原密码有误，请重新输入！');", true);
                   // Response.Write("<script language=javascript>alert('您输入的原密码有误，请重新输入！');</" + "script>");
                    this.adminOldPwd.Text = "";
                    return;
                }
                if (adminNewP!=adminNewPA)
                {
                    ScriptManager.RegisterStartupScript(addBtn, this.GetType(), "showErrorAlert", "showErrorAlert('两次输入密码不一致！请重新输入！');", true);
                    //Response.Write("<script language=javascript>alert('两次输入密码不一致！请重新输入！');</" + "script>");
                    return;
                }
                adminOne.adminPwd = adminNewP;
                adminBll.Update(adminOne);
                ScriptManager.RegisterStartupScript(addBtn, this.GetType(), "showSuccessAlert", "showSuccessAlert('密码更新成功！');", true);
                //Response.Write("<script language=javascript>alert('密码更新成功！');</" + "script>");
            }

        } 
        protected void cancelBtn_Click(object sender, EventArgs e)
        {
            this.adminOldPwd.Text = "";
            this.adminPwd.Text = "";
            this.adminPwdAgain.Text = "";
            ScriptManager.RegisterStartupScript(addBtn, this.GetType(), "showNoticeAlert", "showNoticeAlert('取消更新，文本框置空！');", true);
        } 
    }
}