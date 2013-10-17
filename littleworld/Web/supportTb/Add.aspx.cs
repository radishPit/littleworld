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
namespace littleworld.Web.supportTb
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
			if(!PageValidate.IsNumber(txtsuppoterID.Text))
			{
				strErr+="suppoterID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtsuppotTime.Text))
			{
				strErr+="suppotTime格式错误！\\n";	
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
			int suppoterID=int.Parse(this.txtsuppoterID.Text);
			DateTime suppotTime=DateTime.Parse(this.txtsuppotTime.Text);
			string state=this.txtstate.Text;

			littleworld.Model.supportTb model=new littleworld.Model.supportTb();
			model.noveltyID=noveltyID;
			model.suppoterID=suppoterID;
			model.suppotTime=suppotTime;
			model.state=state;

			littleworld.BLL.supportTb bll=new littleworld.BLL.supportTb();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
