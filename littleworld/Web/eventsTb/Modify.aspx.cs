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
namespace littleworld.Web.eventsTb
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
		littleworld.BLL.eventsTb bll=new littleworld.BLL.eventsTb();
		littleworld.Model.eventsTb model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtoperatorID.Text=model.operatorID.ToString();
		this.txtoperateAction.Text=model.operateAction;
		this.txtoperateContent.Text=model.operateContent;
		this.txtoperateTime.Text=model.operateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtoperatorID.Text))
			{
				strErr+="operatorID格式错误！\\n";	
			}
			if(this.txtoperateAction.Text.Trim().Length==0)
			{
				strErr+="operateAction不能为空！\\n";	
			}
			if(this.txtoperateContent.Text.Trim().Length==0)
			{
				strErr+="operateContent不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtoperateTime.Text))
			{
				strErr+="operateTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			int operatorID=int.Parse(this.txtoperatorID.Text);
			string operateAction=this.txtoperateAction.Text;
			string operateContent=this.txtoperateContent.Text;
			DateTime operateTime=DateTime.Parse(this.txtoperateTime.Text);


			littleworld.Model.eventsTb model=new littleworld.Model.eventsTb();
			model.ID=ID;
			model.operatorID=operatorID;
			model.operateAction=operateAction;
			model.operateContent=operateContent;
			model.operateTime=operateTime;

			littleworld.BLL.eventsTb bll=new littleworld.BLL.eventsTb();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
