using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace littleworld.Web
{
    public partial class userResetPwd : System.Web.UI.Page
    {
       // public string loginemail;
        protected void Page_Load(object sender, EventArgs e)
        {
           // loginemail = Session["no"].ToString();
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
   /*         BLL.userTb bllutb = new BLL.userTb();
            List<Model.userTb> listmodelutb = bllutb.GetModelList("1=1");
            foreach (Model.userTb u in listmodelutb)
            {
                if (u.userEmail == loginemail)
                {
                    u.userPwd = this.txtpwd.Text;
                    bllutb.Update(u);
                }
            }     */

            if (this.txtpwd.Text == "" || this.txtpwdagain.Text == "")
            {
                this.lblmsg3.Visible = true;
                this.lblmsg4.Visible=false;
                this.lblmsg5.Visible = false;
            }
            if (this.txtpwd.Text != this.txtpwdagain.Text && this.txtpwd.Text != "" && this.txtpwdagain.Text != "")
            {
                this.lblmsg3.Visible = false;
                this.lblmsg4.Visible = true;
                this.lblmsg5.Visible = false;
            }
            if (this.txtpwd.Text == this.txtpwdagain.Text && this.txtpwd.Text != "" && this.txtpwdagain.Text != "")
            {
                BLL.userTb bllutb = new BLL.userTb();
                List<Model.userTb> listmodelutb = bllutb.GetModelList("1=1");
                listmodelutb[0].userPwd = this.txtpwd.Text;
                bllutb.Update(listmodelutb[0]);
                this.lblmsg3.Visible = false;
                this.lblmsg4.Visible = false;
                this.lblmsg5.Visible = true;
            }
        }
    }
}