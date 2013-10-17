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
namespace littleworld.Web.noveltyGroupTb
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int noveltyGroupID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(noveltyGroupID);
				}
			}
		}
			
	private void ShowInfo(int noveltyGroupID)
	{
		littleworld.BLL.noveltyGroupTb bll=new littleworld.BLL.noveltyGroupTb();
		littleworld.Model.noveltyGroupTb model=bll.GetModel(noveltyGroupID);
		this.lblnoveltyGroupID.Text=model.noveltyGroupID.ToString();
		this.txtnoveltyGroupName.Text=model.noveltyGroupName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtnoveltyGroupName.Text.Trim().Length==0)
			{
				strErr+="noveltyGroupName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int noveltyGroupID=int.Parse(this.lblnoveltyGroupID.Text);
			string noveltyGroupName=this.txtnoveltyGroupName.Text;


			littleworld.Model.noveltyGroupTb model=new littleworld.Model.noveltyGroupTb();
			model.noveltyGroupID=noveltyGroupID;
			model.noveltyGroupName=noveltyGroupName;

			littleworld.BLL.noveltyGroupTb bll=new littleworld.BLL.noveltyGroupTb();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
