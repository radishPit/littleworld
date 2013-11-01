using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace littleworld.Web
{
    public partial class userLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void loginBtn1_Click(object sender, EventArgs e)
        {
            string email = this.textEmailT.Text.ToString();
            string pwd = this.textPasswordT.Text.ToString();
            BLL.userTb blluser = new BLL.userTb();
            if (email == "" || pwd == "")
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script language=javascript>alert('邮箱与密码不能为空，请重新输入！');</script>",false  );
                return;
            }


            List<Model.userTb> moduser = blluser.GetModelList("userEmail='" + email + "'");
            foreach (Model.userTb moduser1 in  moduser ){
                if (moduser1.state == "0")
                {

                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script language=javascript>alert('您的账号已经被封号！');</script>", false );
                }
                else
                {
                    if (moduser1.userPwd != pwd)
                    {
                        
                        Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script language=javascript>alert('邮箱与密码不匹配，请重新输入！');</script>",false );
                        //this.textEmailT.Text = "";
                        this.textPasswordT.Text = "";
                        return;
                    }


                    Model.eventsTb modevent = new Model.eventsTb();
                    BLL.eventsTb bllevent = new BLL.eventsTb();
                    modevent.operatorID = moduser[0].userID;
                    modevent.operateAction = "用户登陆";
                    modevent.operateContent = "用户登陆成功";
                    modevent.operateTime = System.DateTime.Now.ToLocalTime();
                    bllevent.Add(modevent);

                    Session["no"] = email;
                    Session["pwd"] = pwd;

                    Response.Redirect("userHome.aspx");


                }
            }
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script language=javascript>alert('账号不存在，请重新输入！');</script>", false);
            this.textEmailT.Text = "";
            this.textPasswordT.Text = "";
        }
    }
}