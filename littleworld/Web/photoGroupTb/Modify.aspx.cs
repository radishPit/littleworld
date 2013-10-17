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
namespace littleworld.Web.photoGroupTb
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int photoGroupID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(photoGroupID);
				}
			}
		}
			
	private void ShowInfo(int photoGroupID)
	{
		littleworld.BLL.photoGroupTb bll=new littleworld.BLL.photoGroupTb();
		littleworld.Model.photoGroupTb model=bll.GetModel(photoGroupID);
		this.lblphotoGroupID.Text=model.photoGroupID.ToString();
		this.txtgroupName.Text=model.groupName;
		this.txtownID.Text=model.ownID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtgroupName.Text.Trim().Length==0)
			{
				strErr+="groupName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtownID.Text))
			{
				strErr+="ownID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int photoGroupID=int.Parse(this.lblphotoGroupID.Text);
			string groupName=this.txtgroupName.Text;
			int ownID=int.Parse(this.txtownID.Text);


			littleworld.Model.photoGroupTb model=new littleworld.Model.photoGroupTb();
			model.photoGroupID=photoGroupID;
			model.groupName=groupName;
			model.ownID=ownID;

			littleworld.BLL.photoGroupTb bll=new littleworld.BLL.photoGroupTb();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
