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
namespace littleworld.Web.fansGroupTb
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int fansGroupID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(fansGroupID);
				}
			}
		}
			
	private void ShowInfo(int fansGroupID)
	{
		littleworld.BLL.fansGroupTb bll=new littleworld.BLL.fansGroupTb();
		littleworld.Model.fansGroupTb model=bll.GetModel(fansGroupID);
		this.lblfansGroupID.Text=model.fansGroupID.ToString();
		this.txtgroupName.Text=model.groupName;
		this.txtcreateTime.Text=model.createTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtgroupName.Text.Trim().Length==0)
			{
				strErr+="groupName不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtcreateTime.Text))
			{
				strErr+="createTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int fansGroupID=int.Parse(this.lblfansGroupID.Text);
			string groupName=this.txtgroupName.Text;
			DateTime createTime=DateTime.Parse(this.txtcreateTime.Text);


			littleworld.Model.fansGroupTb model=new littleworld.Model.fansGroupTb();
			model.fansGroupID=fansGroupID;
			model.groupName=groupName;
			model.createTime=createTime;

			littleworld.BLL.fansGroupTb bll=new littleworld.BLL.fansGroupTb();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
