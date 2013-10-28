using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
namespace littleworld.Web
{
    public partial class adminUserDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["userID"]==null)
            {
                return;
            }
            int userID =Convert.ToInt32(Request.QueryString["userID"]);
            BLL.userTb bllUser = new BLL.userTb();
            Model.userTb mUser = bllUser.GetModel(userID);
            this.labelID.Text = mUser.userID.ToString();
            this.labelAddr.Text = mUser.addr;
            this.labelAge.Text = mUser.age.ToString();
            this.labelSex.Text = mUser.sex;
            this.labelUserCollegeSchool.Text = mUser.collegeSchool;
            this.labelUserEmail.Text = mUser.userEmail;
            this.labelUserHighSchool.Text = mUser.highSchool;
            this.labelUserJuniorSchool.Text = mUser.juniorSchool;
            this.labelUserName.Text = mUser.userName;
            this.labelUserPrimarySchool.Text = mUser.primarySchool;
            this.labelUserPwd.Text = mUser.userPwd;
            BLL.interestTb bllInterest = new BLL.interestTb();
            Model.interestTb interset = bllInterest.GetModel(Convert.ToInt32(mUser.interstID));
            this.labelUserInterest.Text = interset.interestName;
            this.userImgs.InnerHtml="<img src='"+mUser.headImgUrl+"'/>";
        }
    }
}