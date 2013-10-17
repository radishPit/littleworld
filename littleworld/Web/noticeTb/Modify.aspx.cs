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
namespace littleworld.Web.noticeTb
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int noticeID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(noticeID);
				}
			}
		}
			
	private void ShowInfo(int noticeID)
	{
		littleworld.BLL.noticeTb bll=new littleworld.BLL.noticeTb();
		littleworld.Model.noticeTb model=bll.GetModel(noticeID);
		this.lblnoticeID.Text=model.noticeID.ToString();
		this.txtadminID.Text=model.adminID.ToString();
		this.txttitle.Text=model.title;
		this.txtcontents.Text=model.contents;
		this.txtsentTime.Text=model.sentTime.ToString();
		this.txtstate.Text=model.state;
		this.txtreceiveID.Text=model.receiveID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtadminID.Text))
			{
				strErr+="adminID格式错误！\\n";	
			}
			if(this.txttitle.Text.Trim().Length==0)
			{
				strErr+="title不能为空！\\n";	
			}
			if(this.txtcontents.Text.Trim().Length==0)
			{
				strErr+="contents不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtsentTime.Text))
			{
				strErr+="sentTime格式错误！\\n";	
			}
			if(this.txtstate.Text.Trim().Length==0)
			{
				strErr+="state不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtreceiveID.Text))
			{
				strErr+="receiveID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int noticeID=int.Parse(this.lblnoticeID.Text);
			int adminID=int.Parse(this.txtadminID.Text);
			string title=this.txttitle.Text;
			string contents=this.txtcontents.Text;
			DateTime sentTime=DateTime.Parse(this.txtsentTime.Text);
			string state=this.txtstate.Text;
			int receiveID=int.Parse(this.txtreceiveID.Text);


			littleworld.Model.noticeTb model=new littleworld.Model.noticeTb();
			model.noticeID=noticeID;
			model.adminID=adminID;
			model.title=title;
			model.contents=contents;
			model.sentTime=sentTime;
			model.state=state;
			model.receiveID=receiveID;

			littleworld.BLL.noticeTb bll=new littleworld.BLL.noticeTb();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
