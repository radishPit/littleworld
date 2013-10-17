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
namespace littleworld.Web.reportTb
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		littleworld.BLL.reportTb bll=new littleworld.BLL.reportTb();
		littleworld.Model.reportTb model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtnoveltyID.Text=model.noveltyID.ToString();
		this.txtreporterID.Text=model.reporterID.ToString();
		this.txtreportTime.Text=model.reportTime.ToString();
		this.txtreportTypeID.Text=model.reportTypeID.ToString();
		this.txtstate.Text=model.state;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtnoveltyID.Text))
			{
				strErr+="noveltyID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtreporterID.Text))
			{
				strErr+="reporterID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtreportTime.Text))
			{
				strErr+="reportTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtreportTypeID.Text))
			{
				strErr+="reportTypeID格式错误！\\n";	
			}
			if(this.txtstate.Text.Trim().Length==0)
			{
				strErr+="state不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			int noveltyID=int.Parse(this.txtnoveltyID.Text);
			int reporterID=int.Parse(this.txtreporterID.Text);
			DateTime reportTime=DateTime.Parse(this.txtreportTime.Text);
			int reportTypeID=int.Parse(this.txtreportTypeID.Text);
			string state=this.txtstate.Text;


			littleworld.Model.reportTb model=new littleworld.Model.reportTb();
			model.ID=ID;
			model.noveltyID=noveltyID;
			model.reporterID=reporterID;
			model.reportTime=reportTime;
			model.reportTypeID=reportTypeID;
			model.state=state;

			littleworld.BLL.reportTb bll=new littleworld.BLL.reportTb();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
