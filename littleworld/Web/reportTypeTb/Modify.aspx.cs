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
namespace littleworld.Web.reportTypeTb
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int reportTypeID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(reportTypeID);
				}
			}
		}
			
	private void ShowInfo(int reportTypeID)
	{
		littleworld.BLL.reportTypeTb bll=new littleworld.BLL.reportTypeTb();
		littleworld.Model.reportTypeTb model=bll.GetModel(reportTypeID);
		this.lblreportTypeID.Text=model.reportTypeID.ToString();
		this.txtreportTypeName.Text=model.reportTypeName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtreportTypeName.Text.Trim().Length==0)
			{
				strErr+="reportTypeName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int reportTypeID=int.Parse(this.lblreportTypeID.Text);
			string reportTypeName=this.txtreportTypeName.Text;


			littleworld.Model.reportTypeTb model=new littleworld.Model.reportTypeTb();
			model.reportTypeID=reportTypeID;
			model.reportTypeName=reportTypeName;

			littleworld.BLL.reportTypeTb bll=new littleworld.BLL.reportTypeTb();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
