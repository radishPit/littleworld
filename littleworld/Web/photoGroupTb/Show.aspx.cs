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
namespace littleworld.Web.photoGroupTb
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
					int photoGroupID=(Convert.ToInt32(strid));
					ShowInfo(photoGroupID);
				}
			}
		}
		
	private void ShowInfo(int photoGroupID)
	{
		littleworld.BLL.photoGroupTb bll=new littleworld.BLL.photoGroupTb();
		littleworld.Model.photoGroupTb model=bll.GetModel(photoGroupID);
		this.lblphotoGroupID.Text=model.photoGroupID.ToString();
		this.lblgroupName.Text=model.groupName;
		this.lblownID.Text=model.ownID.ToString();

	}


    }
}
