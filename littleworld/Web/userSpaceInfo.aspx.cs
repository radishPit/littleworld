using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace littleworld.Web
{
    public partial class userSpaceInfo : System.Web.UI.Page
    {
         private Model.userTb _user;
        public userSpaceInfo()
        {
           
        }
       
        public userSpaceInfo(Model.userTb user)
        {
            this._user = user;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            int userid = 5;
            if (!IsPostBack)
            {
                BLL.userTb blluser = new BLL.userTb();
                Model.userTb f = blluser.GetModel(userid);
                this._user = f;

                this.lbluserage.Text = this._user.age.ToString();
                string username = this._user.userName.ToString();
                this.lblusername.Text = this._user.userName.ToString();
                this.userage.Text = this._user.age.ToString();
                this.lblloginname.Text = this._user.userEmail.ToString();
                this.lblh.Text = this._user.userEmail.ToString();
                // this.lblusername.Text = this._user.userName.ToString();
                this.username.Text = this._user.userName.ToString();

                this.useraddr.Text = this._user.addr.ToString();
                this.lbluseraddr.Text = this._user.addr.ToString();
                this.lblusersax.Text = this._user.sex.ToString();
                if (this.lblusersax.Text == "男")
                {
                    this.man.Checked = true;
                }
                else
                {
                    this.woman.Checked = true;
                }
                this.lblprimarySchool.Text = this._user.primarySchool.ToString();
                this.primarySchool.Text = this._user.primarySchool.ToString();
                this.lbljuniorSchool.Text = this._user.juniorSchool.ToString();
                this.juniorSchool.Text = this._user.juniorSchool.ToString();
                this.lblhighSchool.Text = this._user.highSchool.ToString();
                this.highSchool.Text = this._user.highSchool.ToString();
                this.lblcollegeSchool.Text = this._user.collegeSchool.ToString();
                this.collegeSchool.Text = this._user.collegeSchool.ToString();

            }
        }
    }
}