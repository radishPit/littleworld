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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace littleworld.Web.interestTb
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int interestID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(interestID);
				}
			}
		}
			
	private void ShowInfo(int interestID)
	{
		littleworld.BLL.interestTb bll=new littleworld.BLL.interestTb();
		littleworld.Model.interestTb model=bll.GetModel(interestID);
		this.lblinterestID.Text=model.interestID.ToString();
		this.txtinterestName.Text=model.interestName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtinterestName.Text.Trim().Length==0)
			{
				strErr+="interestName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int interestID=int.Parse(this.lblinterestID.Text);
			string interestName=this.txtinterestName.Text;


			littleworld.Model.interestTb model=new littleworld.Model.interestTb();
			model.interestID=interestID;
			model.interestName=interestName;

			littleworld.BLL.interestTb bll=new littleworld.BLL.interestTb();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
