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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			int operatorID=int.Parse(this.txtoperatorID.Text);
			string operateAction=this.txtoperateAction.Text;
			string operateContent=this.txtoperateContent.Text;
			DateTime operateTime=DateTime.Parse(this.txtoperateTime.Text);

			littleworld.Model.eventsTb model=new littleworld.Model.eventsTb();
			model.operatorID=operatorID;
			model.operateAction=operateAction;
			model.operateContent=operateContent;
			model.operateTime=operateTime;

			littleworld.BLL.eventsTb bll=new littleworld.BLL.eventsTb();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
