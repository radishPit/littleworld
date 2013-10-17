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
namespace littleworld.Web.webInfoTb
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
		littleworld.BLL.webInfoTb bll=new littleworld.BLL.webInfoTb();
		littleworld.Model.webInfoTb model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtwebName.Text=model.webName;
		this.txtlogoURL.Text=model.logoURL;
		this.txtlastPub.Text=model.lastPub.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtwebName.Text.Trim().Length==0)
			{
				strErr+="webName不能为空！\\n";	
			}
			if(this.txtlogoURL.Text.Trim().Length==0)
			{
				strErr+="logoURL不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtlastPub.Text))
			{
				strErr+="lastPub格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string webName=this.txtwebName.Text;
			string logoURL=this.txtlogoURL.Text;
			DateTime lastPub=DateTime.Parse(this.txtlastPub.Text);


			littleworld.Model.webInfoTb model=new littleworld.Model.webInfoTb();
			model.ID=ID;
			model.webName=webName;
			model.logoURL=logoURL;
			model.lastPub=lastPub;

			littleworld.BLL.webInfoTb bll=new littleworld.BLL.webInfoTb();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
