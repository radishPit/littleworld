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
namespace littleworld.Web.noticeTb
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
					int noticeID=(Convert.ToInt32(strid));
					ShowInfo(noticeID);
				}
			}
		}
		
	private void ShowInfo(int noticeID)
	{
		littleworld.BLL.noticeTb bll=new littleworld.BLL.noticeTb();
		littleworld.Model.noticeTb model=bll.GetModel(noticeID);
		this.lblnoticeID.Text=model.noticeID.ToString();
		this.lbladminID.Text=model.adminID.ToString();
		this.lbltitle.Text=model.title;
		this.lblcontents.Text=model.contents;
		this.lblsentTime.Text=model.sentTime.ToString();
		this.lblstate.Text=model.state;
		this.lblreceiveID.Text=model.receiveID.ToString();

	}


    }
}
