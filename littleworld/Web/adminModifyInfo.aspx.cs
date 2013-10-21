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
        protected void sureBtn_Click(object sender, EventArgs e)
        {
            
        } 
        protected void cancelBtn_Click(object sender, EventArgs e)
        {
            this.adminOldPwd.Text = "";
            this.adminPwd.Text = "";
            this.adminPwdAgain.Text = "";
        } 
    }
}