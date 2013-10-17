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
namespace littleworld.Web.commentTb
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
		littleworld.BLL.commentTb bll=new littleworld.BLL.commentTb();
		littleworld.Model.commentTb model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblnoveltyID.Text=model.noveltyID.ToString();
		this.lblcommenterID.Text=model.commenterID.ToString();
		this.lblcontents.Text=model.contents;
		this.lblcommentTime.Text=model.commentTime.ToString();
		this.lblparentID.Text=model.parentID.ToString();
		this.lblstate.Text=model.state;

	}


    }
}
