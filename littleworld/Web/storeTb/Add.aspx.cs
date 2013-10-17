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
namespace littleworld.Web.storeTb
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
			if(!PageValidate.IsNumber(txtstorerID.Text))
			{
				strErr+="storerID格式错误！\\n";	
			}
			if(this.txttitle.Text.Trim().Length==0)
			{
				strErr+="title不能为空！\\n";	
			}
			if(this.txtstate.Text.Trim().Length==0)
			{
				strErr+="state不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstoreTime.Text))
			{
				strErr+="storeTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int noveltyID=int.Parse(this.txtnoveltyID.Text);
			int storerID=int.Parse(this.txtstorerID.Text);
			string title=this.txttitle.Text;
			string state=this.txtstate.Text;
			DateTime storeTime=DateTime.Parse(this.txtstoreTime.Text);

			littleworld.Model.storeTb model=new littleworld.Model.storeTb();
			model.noveltyID=noveltyID;
			model.storerID=storerID;
			model.title=title;
			model.state=state;
			model.storeTime=storeTime;

			littleworld.BLL.storeTb bll=new littleworld.BLL.storeTb();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
