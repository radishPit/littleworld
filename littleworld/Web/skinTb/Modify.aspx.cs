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
namespace littleworld.Web.skinTb
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
		littleworld.BLL.skinTb bll=new littleworld.BLL.skinTb();
		littleworld.Model.skinTb model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtskinName.Text=model.skinName;
		this.txtimgUrl.Text=model.imgUrl;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtskinName.Text.Trim().Length==0)
			{
				strErr+="skinName不能为空！\\n";	
			}
			if(this.txtimgUrl.Text.Trim().Length==0)
			{
				strErr+="imgUrl不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string skinName=this.txtskinName.Text;
			string imgUrl=this.txtimgUrl.Text;


			littleworld.Model.skinTb model=new littleworld.Model.skinTb();
			model.ID=ID;
			model.skinName=skinName;
			model.imgUrl=imgUrl;

			littleworld.BLL.skinTb bll=new littleworld.BLL.skinTb();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
