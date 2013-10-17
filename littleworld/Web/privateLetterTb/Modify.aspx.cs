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
namespace littleworld.Web.privateLetterTb
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
		littleworld.BLL.privateLetterTb bll=new littleworld.BLL.privateLetterTb();
		littleworld.Model.privateLetterTb model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtsenderID.Text=model.senderID.ToString();
		this.txtreceiveID.Text=model.receiveID.ToString();
		this.txtcontents.Text=model.contents;
		this.txtsendTime.Text=model.sendTime.ToString();
		this.txtstate.Text=model.state;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtsenderID.Text))
			{
				strErr+="senderID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtreceiveID.Text))
			{
				strErr+="receiveID格式错误！\\n";	
			}
			if(this.txtcontents.Text.Trim().Length==0)
			{
				strErr+="contents不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtsendTime.Text))
			{
				strErr+="sendTime格式错误！\\n";	
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
			int senderID=int.Parse(this.txtsenderID.Text);
			int receiveID=int.Parse(this.txtreceiveID.Text);
			string contents=this.txtcontents.Text;
			DateTime sendTime=DateTime.Parse(this.txtsendTime.Text);
			string state=this.txtstate.Text;


			littleworld.Model.privateLetterTb model=new littleworld.Model.privateLetterTb();
			model.ID=ID;
			model.senderID=senderID;
			model.receiveID=receiveID;
			model.contents=contents;
			model.sendTime=sendTime;
			model.state=state;

			littleworld.BLL.privateLetterTb bll=new littleworld.BLL.privateLetterTb();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
