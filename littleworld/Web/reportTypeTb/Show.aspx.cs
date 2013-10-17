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
namespace littleworld.Web.reportTypeTb
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
					int reportTypeID=(Convert.ToInt32(strid));
					ShowInfo(reportTypeID);
				}
			}
		}
		
	private void ShowInfo(int reportTypeID)
	{
		littleworld.BLL.reportTypeTb bll=new littleworld.BLL.reportTypeTb();
		littleworld.Model.reportTypeTb model=bll.GetModel(reportTypeID);
		this.lblreportTypeID.Text=model.reportTypeID.ToString();
		this.lblreportTypeName.Text=model.reportTypeName;

	}


    }
}
