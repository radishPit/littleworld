using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace littleworld.Web.userTb
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int userID=(Convert.ToInt32(strid));
					ShowInfo(userID);
				}
			}
		}
		
	private void ShowInfo(int userID)
	{
		littleworld.BLL.userTb bll=new littleworld.BLL.userTb();
		littleworld.Model.userTb model=bll.GetModel(userID);
		this.lbluserID.Text=model.userID.ToString();
		this.lbluserName.Text=model.userName;
		this.lbluserEmail.Text=model.userEmail;
		this.lbluserPwd.Text=model.userPwd;
		this.lblheadImgUrl.Text=model.headImgUrl;
		this.lblsex.Text=model.sex;
		this.lbladdr.Text=model.addr;
		this.lblage.Text=model.age.ToString();
		this.lblprimarySchool.Text=model.primarySchool;
		this.lbljuniorSchool.Text=model.juniorSchool;
		this.lblhighSchool.Text=model.highSchool;
		this.lblcollegeSchool.Text=model.collegeSchool;
		this.lblinterstID.Text=model.interstID.ToString();
		this.lblstate.Text=model.state;
		this.lblgroupID.Text=model.groupID.ToString();
		this.lblreprotNum.Text=model.reprotNum.ToString();
		this.lblskinID.Text=model.skinID.ToString();

	}


    }
}
