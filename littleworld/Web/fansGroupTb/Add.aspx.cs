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
namespace littleworld.Web.fansGroupTb
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtgroupName.Text.Trim().Length==0)
			{
				strErr+="groupName不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtcreateTime.Text))
			{
				strErr+="createTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string groupName=this.txtgroupName.Text;
			DateTime createTime=DateTime.Parse(this.txtcreateTime.Text);

			littleworld.Model.fansGroupTb model=new littleworld.Model.fansGroupTb();
			model.groupName=groupName;
			model.createTime=createTime;

			littleworld.BLL.fansGroupTb bll=new littleworld.BLL.fansGroupTb();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
