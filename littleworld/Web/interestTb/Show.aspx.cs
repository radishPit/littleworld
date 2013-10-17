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
namespace littleworld.Web.interestTb
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
					int interestID=(Convert.ToInt32(strid));
					ShowInfo(interestID);
				}
			}
		}
		
	private void ShowInfo(int interestID)
	{
		littleworld.BLL.interestTb bll=new littleworld.BLL.interestTb();
		littleworld.Model.interestTb model=bll.GetModel(interestID);
		this.lblinterestID.Text=model.interestID.ToString();
		this.lblinterestName.Text=model.interestName;

	}


    }
}
