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
namespace littleworld.Web.noveltyImagesTb
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
		littleworld.BLL.noveltyImagesTb bll=new littleworld.BLL.noveltyImagesTb();
		littleworld.Model.noveltyImagesTb model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtnoveltyID.Text=model.noveltyID.ToString();
		this.txtimgUrl.Text=model.imgUrl;
		this.txtsmallImgUrl.Text=model.smallImgUrl;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtnoveltyID.Text))
			{
				strErr+="noveltyID格式错误！\\n";	
			}
			if(this.txtimgUrl.Text.Trim().Length==0)
			{
				strErr+="imgUrl不能为空！\\n";	
			}
			if(this.txtsmallImgUrl.Text.Trim().Length==0)
			{
				strErr+="smallImgUrl不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			int noveltyID=int.Parse(this.txtnoveltyID.Text);
			string imgUrl=this.txtimgUrl.Text;
			string smallImgUrl=this.txtsmallImgUrl.Text;


			littleworld.Model.noveltyImagesTb model=new littleworld.Model.noveltyImagesTb();
			model.ID=ID;
			model.noveltyID=noveltyID;
			model.imgUrl=imgUrl;
			model.smallImgUrl=smallImgUrl;

			littleworld.BLL.noveltyImagesTb bll=new littleworld.BLL.noveltyImagesTb();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
