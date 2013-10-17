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
namespace littleworld.Web.adminTb
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
					int adminID=(Convert.ToInt32(strid));
					ShowInfo(adminID);
				}
			}
		}
		
	private void ShowInfo(int adminID)
	{
		littleworld.BLL.adminTb bll=new littleworld.BLL.adminTb();
		littleworld.Model.adminTb model=bll.GetModel(adminID);
		this.lbladminID.Text=model.adminID.ToString();
		this.lbladminName.Text=model.adminName;
		this.lbladminPwd.Text=model.adminPwd;
		this.lbladminEmail.Text=model.adminEmail;
		this.lbladminLevel.Text=model.adminLevel.ToString();

	}


    }
}
