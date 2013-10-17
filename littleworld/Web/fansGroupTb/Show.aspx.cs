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
namespace littleworld.Web.fansGroupTb
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
					int fansGroupID=(Convert.ToInt32(strid));
					ShowInfo(fansGroupID);
				}
			}
		}
		
	private void ShowInfo(int fansGroupID)
	{
		littleworld.BLL.fansGroupTb bll=new littleworld.BLL.fansGroupTb();
		littleworld.Model.fansGroupTb model=bll.GetModel(fansGroupID);
		this.lblfansGroupID.Text=model.fansGroupID.ToString();
		this.lblgroupName.Text=model.groupName;
		this.lblcreateTime.Text=model.createTime.ToString();

	}


    }
}
