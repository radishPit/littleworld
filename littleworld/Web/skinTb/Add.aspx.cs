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
namespace littleworld.Web.skinTb
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtskinName.Text.Trim().Length==0)
			{
				strErr+="skinName不能为空！\\n";	
			}
			if(this.txtimgUrl.Text.Trim().Length==0)
			{
				strErr+="imgUrl不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string skinName=this.txtskinName.Text;
			string imgUrl=this.txtimgUrl.Text;

			littleworld.Model.skinTb model=new littleworld.Model.skinTb();
			model.skinName=skinName;
			model.imgUrl=imgUrl;

			littleworld.BLL.skinTb bll=new littleworld.BLL.skinTb();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
