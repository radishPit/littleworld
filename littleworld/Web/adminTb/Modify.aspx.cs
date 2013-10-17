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
namespace littleworld.Web.adminTb
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int adminID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(adminID);
				}
			}
		}
			
	private void ShowInfo(int adminID)
	{
		littleworld.BLL.adminTb bll=new littleworld.BLL.adminTb();
		littleworld.Model.adminTb model=bll.GetModel(adminID);
		this.lbladminID.Text=model.adminID.ToString();
		this.txtadminName.Text=model.adminName;
		this.txtadminPwd.Text=model.adminPwd;
		this.txtadminEmail.Text=model.adminEmail;
		this.txtadminLevel.Text=model.adminLevel.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtadminName.Text.Trim().Length==0)
			{
				strErr+="adminName不能为空！\\n";	
			}
			if(this.txtadminPwd.Text.Trim().Length==0)
			{
				strErr+="adminPwd不能为空！\\n";	
			}
			if(this.txtadminEmail.Text.Trim().Length==0)
			{
				strErr+="adminEmail不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtadminLevel.Text))
			{
				strErr+="adminLevel格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int adminID=int.Parse(this.lbladminID.Text);
			string adminName=this.txtadminName.Text;
			string adminPwd=this.txtadminPwd.Text;
			string adminEmail=this.txtadminEmail.Text;
			int adminLevel=int.Parse(this.txtadminLevel.Text);


			littleworld.Model.adminTb model=new littleworld.Model.adminTb();
			model.adminID=adminID;
			model.adminName=adminName;
			model.adminPwd=adminPwd;
			model.adminEmail=adminEmail;
			model.adminLevel=adminLevel;

			littleworld.BLL.adminTb bll=new littleworld.BLL.adminTb();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
