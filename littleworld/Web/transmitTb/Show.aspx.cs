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
namespace littleworld.Web.transmitTb
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
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		littleworld.BLL.transmitTb bll=new littleworld.BLL.transmitTb();
		littleworld.Model.transmitTb model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblnoveltyID.Text=model.noveltyID.ToString();
		this.lbltransmiterID.Text=model.transmiterID.ToString();
		this.lblpower.Text=model.power.ToString();
		this.lblcontents.Text=model.contents;
		this.lbltransmitTime.Text=model.transmitTime.ToString();
		this.lblstate.Text=model.state;

	}


    }
}
