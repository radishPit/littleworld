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
namespace littleworld.Web.noveltyGroupTb
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
					int noveltyGroupID=(Convert.ToInt32(strid));
					ShowInfo(noveltyGroupID);
				}
			}
		}
		
	private void ShowInfo(int noveltyGroupID)
	{
		littleworld.BLL.noveltyGroupTb bll=new littleworld.BLL.noveltyGroupTb();
		littleworld.Model.noveltyGroupTb model=bll.GetModel(noveltyGroupID);
		this.lblnoveltyGroupID.Text=model.noveltyGroupID.ToString();
		this.lblnoveltyGroupName.Text=model.noveltyGroupName;

	}


    }
}
