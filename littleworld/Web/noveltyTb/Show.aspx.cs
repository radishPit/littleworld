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
namespace littleworld.Web.noveltyTb
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
					int noveltyID=(Convert.ToInt32(strid));
					ShowInfo(noveltyID);
				}
			}
		}
		
	private void ShowInfo(int noveltyID)
	{
		littleworld.BLL.noveltyTb bll=new littleworld.BLL.noveltyTb();
		littleworld.Model.noveltyTb model=bll.GetModel(noveltyID);
		this.lblnoveltyID.Text=model.noveltyID.ToString();
		this.lblsenderID.Text=model.senderID.ToString();
		this.lblcontents.Text=model.contents;
		this.lblstate.Text=model.state;
		this.lblhasImgs.Text=model.hasImgs.ToString();
		this.lbltypeID.Text=model.typeID.ToString();
		this.lblcommentNum.Text=model.commentNum.ToString();
		this.lblsupportNum.Text=model.supportNum.ToString();
		this.lblreportNum.Text=model.reportNum.ToString();
		this.lbltransmitNum.Text=model.transmitNum.ToString();
		this.lblpublishtime.Text=model.publishtime.ToString();

	}


    }
}
