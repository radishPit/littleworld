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
namespace littleworld.Web.userTb
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int userID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(userID);
				}
			}
		}
			
	private void ShowInfo(int userID)
	{
		littleworld.BLL.userTb bll=new littleworld.BLL.userTb();
		littleworld.Model.userTb model=bll.GetModel(userID);
		this.lbluserID.Text=model.userID.ToString();
		this.txtuserName.Text=model.userName;
		this.txtuserEmail.Text=model.userEmail;
		this.txtuserPwd.Text=model.userPwd;
		this.txtheadImgUrl.Text=model.headImgUrl;
		this.txtsex.Text=model.sex;
		this.txtaddr.Text=model.addr;
		this.txtage.Text=model.age.ToString();
		this.txtprimarySchool.Text=model.primarySchool;
		this.txtjuniorSchool.Text=model.juniorSchool;
		this.txthighSchool.Text=model.highSchool;
		this.txtcollegeSchool.Text=model.collegeSchool;
		this.txtinterstID.Text=model.interstID.ToString();
		this.txtstate.Text=model.state;
		this.txtgroupID.Text=model.groupID.ToString();
		this.txtreprotNum.Text=model.reprotNum.ToString();
		this.txtskinID.Text=model.skinID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtuserName.Text.Trim().Length==0)
			{
				strErr+="userName不能为空！\\n";	
			}
			if(this.txtuserEmail.Text.Trim().Length==0)
			{
				strErr+="userEmail不能为空！\\n";	
			}
			if(this.txtuserPwd.Text.Trim().Length==0)
			{
				strErr+="userPwd不能为空！\\n";	
			}
			if(this.txtheadImgUrl.Text.Trim().Length==0)
			{
				strErr+="headImgUrl不能为空！\\n";	
			}
			if(this.txtsex.Text.Trim().Length==0)
			{
				strErr+="sex不能为空！\\n";	
			}
			if(this.txtaddr.Text.Trim().Length==0)
			{
				strErr+="addr不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtage.Text))
			{
				strErr+="age格式错误！\\n";	
			}
			if(this.txtprimarySchool.Text.Trim().Length==0)
			{
				strErr+="primarySchool不能为空！\\n";	
			}
			if(this.txtjuniorSchool.Text.Trim().Length==0)
			{
				strErr+="juniorSchool不能为空！\\n";	
			}
			if(this.txthighSchool.Text.Trim().Length==0)
			{
				strErr+="highSchool不能为空！\\n";	
			}
			if(this.txtcollegeSchool.Text.Trim().Length==0)
			{
				strErr+="collegeSchool不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtinterstID.Text))
			{
				strErr+="interstID格式错误！\\n";	
			}
			if(this.txtstate.Text.Trim().Length==0)
			{
				strErr+="state不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtgroupID.Text))
			{
				strErr+="groupID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtreprotNum.Text))
			{
				strErr+="reprotNum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtskinID.Text))
			{
				strErr+="skinID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int userID=int.Parse(this.lbluserID.Text);
			string userName=this.txtuserName.Text;
			string userEmail=this.txtuserEmail.Text;
			string userPwd=this.txtuserPwd.Text;
			string headImgUrl=this.txtheadImgUrl.Text;
			string sex=this.txtsex.Text;
			string addr=this.txtaddr.Text;
			int age=int.Parse(this.txtage.Text);
			string primarySchool=this.txtprimarySchool.Text;
			string juniorSchool=this.txtjuniorSchool.Text;
			string highSchool=this.txthighSchool.Text;
			string collegeSchool=this.txtcollegeSchool.Text;
			int interstID=int.Parse(this.txtinterstID.Text);
			string state=this.txtstate.Text;
			int groupID=int.Parse(this.txtgroupID.Text);
			int reprotNum=int.Parse(this.txtreprotNum.Text);
			int skinID=int.Parse(this.txtskinID.Text);


			littleworld.Model.userTb model=new littleworld.Model.userTb();
			model.userID=userID;
			model.userName=userName;
			model.userEmail=userEmail;
			model.userPwd=userPwd;
			model.headImgUrl=headImgUrl;
			model.sex=sex;
			model.addr=addr;
			model.age=age;
			model.primarySchool=primarySchool;
			model.juniorSchool=juniorSchool;
			model.highSchool=highSchool;
			model.collegeSchool=collegeSchool;
			model.interstID=interstID;
			model.state=state;
			model.groupID=groupID;
			model.reprotNum=reprotNum;
			model.skinID=skinID;

			littleworld.BLL.userTb bll=new littleworld.BLL.userTb();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
