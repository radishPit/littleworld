using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace littleworld.Web
{
    public partial class userInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }


        protected void btnOK_Click(object sender, EventArgs e)
        {
            string addr = this.txtaddr.Text.ToString();
            string pri = this.txtpri.Text.ToString();
            string mid = this.txtmid.Text.ToString();
            string sen = this.txtsenior.Text.ToString();
            string col = this.txtcol.Text.ToString();
            string age = this.txtage.Text.ToString();

            BLL.userTb blluser = new BLL.userTb();
            Model.userTb moduser = new Model.userTb();
            moduser.addr = addr;
            moduser.primarySchool = pri;
            moduser.juniorSchool = mid;
            moduser.highSchool = sen;
            moduser.collegeSchool = col;
            moduser.age = Convert .ToInt32 (age);
            moduser.userName = Session["name"].ToString ();
            moduser.userEmail = Session["email"].ToString();
            if (Rbtnsex.Checked)
            {
                moduser.sex = "男";
            }
            else {
                moduser.sex = "女";
            }
           if(this.DropDownList1.Text =="游泳")
           {
               moduser.interstID = 1;
           }
           if (this.DropDownList1.Text == "旅游")
           {
               moduser.interstID = 2;
           }
           if (this.DropDownList1.Text == "登山")
           {
               moduser.interstID = 3;
           }
           if (this.DropDownList1.Text == "听音乐")
           {
               moduser.interstID = 4;
           }
           if (this.DropDownList1.Text == "看书")
           {
               moduser.interstID = 5;
           }
           if (this.DropDownList1.Text == "蹦极")
           {
               moduser.interstID = 6;
           }
           if (this.DropDownList1.Text == "娱乐八卦")
           {
               moduser.interstID = 7;
           }
            moduser.userPwd =Session["pwd"].ToString();
            moduser.headImgUrl = "..\\images\\userInfoImg\\headimage1.gif";

            int t = blluser.Add(moduser);
            if (t <= 0)
            {
                Response.Write("保存失败，请重新输入！");

            }
            Response.Write("保存成功！");

        }


    
    }
}