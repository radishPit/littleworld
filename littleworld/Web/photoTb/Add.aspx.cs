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
namespace littleworld.Web.photoTb
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtphotoID.Text))
			{
				strErr+="photoID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtownID.Text))
			{
				strErr+="ownID格式错误！\\n";	
			}
			if(this.txtdescription.Text.Trim().Length==0)
			{
				strErr+="description不能为空！\\n";	
			}
			if(this.txtimgUrl.Text.Trim().Length==0)
			{
				strErr+="imgUrl不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtphotoGroupID.Text))
			{
				strErr+="photoGroupID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtcreatTime.Text))
			{
				strErr+="creatTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int photoID=int.Parse(this.txtphotoID.Text);
			int ownID=int.Parse(this.txtownID.Text);
			string description=this.txtdescription.Text;
			string imgUrl=this.txtimgUrl.Text;
			int photoGroupID=int.Parse(this.txtphotoGroupID.Text);
			DateTime creatTime=DateTime.Parse(this.txtcreatTime.Text);

			littleworld.Model.photoTb model=new littleworld.Model.photoTb();
			model.photoID=photoID;
			model.ownID=ownID;
			model.description=description;
			model.imgUrl=imgUrl;
			model.photoGroupID=photoGroupID;
			model.creatTime=creatTime;

			littleworld.BLL.photoTb bll=new littleworld.BLL.photoTb();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
