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
namespace littleworld.Web.commentTb
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtnoveltyID.Text))
			{
				strErr+="noveltyID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcommenterID.Text))
			{
				strErr+="commenterID格式错误！\\n";	
			}
			if(this.txtcontents.Text.Trim().Length==0)
			{
				strErr+="contents不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtcommentTime.Text))
			{
				strErr+="commentTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtparentID.Text))
			{
				strErr+="parentID格式错误！\\n";	
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
			int noveltyID=int.Parse(this.txtnoveltyID.Text);
			int commenterID=int.Parse(this.txtcommenterID.Text);
			string contents=this.txtcontents.Text;
			DateTime commentTime=DateTime.Parse(this.txtcommentTime.Text);
			int parentID=int.Parse(this.txtparentID.Text);
			string state=this.txtstate.Text;

			littleworld.Model.commentTb model=new littleworld.Model.commentTb();
			model.noveltyID=noveltyID;
			model.commenterID=commenterID;
			model.contents=contents;
			model.commentTime=commentTime;
			model.parentID=parentID;
			model.state=state;

			littleworld.BLL.commentTb bll=new littleworld.BLL.commentTb();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
