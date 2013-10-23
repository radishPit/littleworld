using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace littleworld.Web
{
    public partial class userResetPwd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void submit_passworda_Click(object sender, EventArgs e)
        {
           BLL.userTb buser= new BLL.userTb();
               List<Model.userTb> lmuser = buser.GetModelList("1=1");

               if (this.newpswCtext.Text == this.surepswCtext.Text && this.newpswCtext.Text == "")
               {
              this.lblSuccessC.Visible = false;
                   this.newpswCR2.Visible = true;
                   this.surepswCR2.Visible = false;
               }
               if (this.newpswCtext.Text != this.surepswCtext.Text)
               {
              this.lblSuccessC.Visible = false;
                   this.surepswCR2.Visible = true;
                   this.newpswCR2.Visible = false;
               }
               if (this.newpswCtext.Text == this.surepswCtext.Text && this.newpswCtext.Text!="")
                   // Response.Write("密码不一致!");
               {
              this.lblSuccessC.Visible = true;
                   this.surepswCR2.Visible = false;
                   this.newpswCR2.Visible = false;
                   lmuser[0].userPwd = this.newpswCtext.Text;
                   buser.Update(lmuser[0]);
               } 
        }
    }
}