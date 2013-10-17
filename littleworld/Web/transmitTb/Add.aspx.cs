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
namespace littleworld.Web.transmitTb
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
			if(!PageValidate.IsNumber(txttransmiterID.Text))
			{
				strErr+="transmiterID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpower.Text))
			{
				strErr+="power格式错误！\\n";	
			}
			if(this.txtcontents.Text.Trim().Length==0)
			{
				strErr+="contents不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txttransmitTime.Text))
			{
				strErr+="transmitTime格式错误！\\n";	
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
			int transmiterID=int.Parse(this.txttransmiterID.Text);
			int power=int.Parse(this.txtpower.Text);
			string contents=this.txtcontents.Text;
			DateTime transmitTime=DateTime.Parse(this.txttransmitTime.Text);
			string state=this.txtstate.Text;

			littleworld.Model.transmitTb model=new littleworld.Model.transmitTb();
			model.noveltyID=noveltyID;
			model.transmiterID=transmiterID;
			model.power=power;
			model.contents=contents;
			model.transmitTime=transmitTime;
			model.state=state;

			littleworld.BLL.transmitTb bll=new littleworld.BLL.transmitTb();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
