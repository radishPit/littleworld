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
namespace littleworld.Web.fansTb
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtownID.Text))
			{
				strErr+="ownID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtownedID.Text))
			{
				strErr+="ownedID格式错误！\\n";	
			}
			if(this.txtownedName.Text.Trim().Length==0)
			{
				strErr+="ownedName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtgroupID.Text))
			{
				strErr+="groupID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ownID=int.Parse(this.txtownID.Text);
			int ownedID=int.Parse(this.txtownedID.Text);
			string ownedName=this.txtownedName.Text;
			int groupID=int.Parse(this.txtgroupID.Text);

			littleworld.Model.fansTb model=new littleworld.Model.fansTb();
			model.ownID=ownID;
			model.ownedID=ownedID;
			model.ownedName=ownedName;
			model.groupID=groupID;

			littleworld.BLL.fansTb bll=new littleworld.BLL.fansTb();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
