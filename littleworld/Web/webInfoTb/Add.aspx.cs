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
namespace littleworld.Web.webInfoTb
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtwebName.Text.Trim().Length==0)
			{
				strErr+="webName不能为空！\\n";	
			}
			if(this.txtlogoURL.Text.Trim().Length==0)
			{
				strErr+="logoURL不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtlastPub.Text))
			{
				strErr+="lastPub格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string webName=this.txtwebName.Text;
			string logoURL=this.txtlogoURL.Text;
			DateTime lastPub=DateTime.Parse(this.txtlastPub.Text);

			littleworld.Model.webInfoTb model=new littleworld.Model.webInfoTb();
			model.webName=webName;
			model.logoURL=logoURL;
			model.lastPub=lastPub;

			littleworld.BLL.webInfoTb bll=new littleworld.BLL.webInfoTb();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
