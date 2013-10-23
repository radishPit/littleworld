using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace littleworld.Web
{
    public partial class userSpace : System.Web.UI.Page
    {
        private Model.userTb _user;
        public userSpace()
        {
           
        }
        public userSpace(Model.userTb user)
        {
            this._user = user;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.userTb blluser = new BLL.userTb();
            Model.userTb f = blluser.GetModel(5);
            this._user = f;
            this.lblname.Text = this._user.userName.ToString();
            string sax = this._user.sex.ToString();
            if (sax == "女")
            {
                this.imgsax.ImageUrl = "../images/userSpaceImg/girl.gif";
            }
            else 
            {
                this.imgsax.ImageUrl = "../images/userSpaceImg/boy.gif";

            }
            this.state.InnerText= this._user.addr.ToString();
            this.conlege.InnerText = this._user.collegeSchool.ToString();
            this.imghead.ImageUrl = this._user.headImgUrl.ToString();
            this.lbluserage.Text = this._user.age.ToString();
            this.userage.Value = this._user.age.ToString();
            this.lblloginname.Text = this._user.userEmail.ToString();
            this.lblh.Text = this._user.userEmail.ToString();
            this.lblusername.Text = this._user.userName.ToString();
            this.username.Value = this._user.userName.ToString();
            this.useraddr.Value = this._user.addr.ToString();
            this.lbluseraddr.Text = this._user.addr.ToString();
            this.lblusersax.Text = this._user.sex.ToString();
            if (this.lblusersax.Text == "男")
            {
                this.man.Checked = true;
            }
            else {
                this.woman.Checked = true;
            }
            this.lblprimarySchool.Text = this._user.primarySchool.ToString();
            this.primarySchool.Value = this._user.primarySchool.ToString();
            this.lbljuniorSchool.Text = this._user.juniorSchool.ToString();
            this.juniorSchool.Value = this._user.juniorSchool.ToString();
            this.lblhighSchool.Text = this._user.highSchool.ToString();
            this.highSchool.Value= this._user.highSchool.ToString();
            this.lblcollegeSchool.Text = this._user.collegeSchool.ToString();
            this.collegeSchool.Value = this._user.collegeSchool.ToString();
          

           
            
        }
    }
}