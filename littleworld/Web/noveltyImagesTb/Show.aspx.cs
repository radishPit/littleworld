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
namespace littleworld.Web.noveltyImagesTb
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
		littleworld.BLL.noveltyImagesTb bll=new littleworld.BLL.noveltyImagesTb();
		littleworld.Model.noveltyImagesTb model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblnoveltyID.Text=model.noveltyID.ToString();
		this.lblimgUrl.Text=model.imgUrl;
		this.lblsmallImgUrl.Text=model.smallImgUrl;

	}


    }
}
