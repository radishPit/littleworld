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
namespace littleworld.Web.noveltyTb
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtsenderID.Text))
			{
				strErr+="senderID格式错误！\\n";	
			}
			if(this.txtcontents.Text.Trim().Length==0)
			{
				strErr+="contents不能为空！\\n";	
			}
			if(this.txtstate.Text.Trim().Length==0)
			{
				strErr+="state不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txthasImgs.Text))
			{
				strErr+="hasImgs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txttypeID.Text))
			{
				strErr+="typeID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommentNum.Text))
			{
				strErr+="commentNum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsupportNum.Text))
			{
				strErr+="supportNum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtreportNum.Text))
			{
				strErr+="reportNum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txttransmitNum.Text))
			{
				strErr+="transmitNum格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtpublishtime.Text))
			{
				strErr+="publishtime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int senderID=int.Parse(this.txtsenderID.Text);
			string contents=this.txtcontents.Text;
			string state=this.txtstate.Text;
			int hasImgs=int.Parse(this.txthasImgs.Text);
			int typeID=int.Parse(this.txttypeID.Text);
			int commentNum=int.Parse(this.txtcommentNum.Text);
			int supportNum=int.Parse(this.txtsupportNum.Text);
			int reportNum=int.Parse(this.txtreportNum.Text);
			int transmitNum=int.Parse(this.txttransmitNum.Text);
			DateTime publishtime=DateTime.Parse(this.txtpublishtime.Text);

			littleworld.Model.noveltyTb model=new littleworld.Model.noveltyTb();
			model.senderID=senderID;
			model.contents=contents;
			model.state=state;
			model.hasImgs=hasImgs;
			model.typeID=typeID;
			model.commentNum=commentNum;
			model.supportNum=supportNum;
			model.reportNum=reportNum;
			model.transmitNum=transmitNum;
			model.publishtime=publishtime;

			littleworld.BLL.noveltyTb bll=new littleworld.BLL.noveltyTb();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
