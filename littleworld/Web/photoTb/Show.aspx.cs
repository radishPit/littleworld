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
namespace littleworld.Web.photoTb
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
					int photoID=(Convert.ToInt32(strid));
					ShowInfo(photoID);
				}
			}
		}
		
	private void ShowInfo(int photoID)
	{
		littleworld.BLL.photoTb bll=new littleworld.BLL.photoTb();
		littleworld.Model.photoTb model=bll.GetModel(photoID);
		this.lblphotoID.Text=model.photoID.ToString();
		this.lblownID.Text=model.ownID.ToString();
		this.lbldescription.Text=model.description;
		this.lblimgUrl.Text=model.imgUrl;
		this.lblphotoGroupID.Text=model.photoGroupID.ToString();
		this.lblcreatTime.Text=model.creatTime.ToString();

	}


    }
}
