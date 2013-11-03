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

        string Mpath;

       protected void BtnUpload_Click(object sender, EventArgs e)
       {
           bool fileOK = false;
           string path = Server.MapPath("~/images/Temp/");
           if (FileUpload1.HasFile)
           {
               String fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
               String[] allowedExtensions = { ".gif", ".png", ".bmp", ".jpg" };
               for (int i = 0; i < allowedExtensions.Length; i++)
               {
                   if (fileExtension == allowedExtensions[i])
                   {
                       fileOK = true;
                   }
               }
           }
           if (fileOK)
           {
               try
               {
                   Mpath = Guid.NewGuid().ToString() + System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                   FileUpload1.SaveAs(path+Mpath );
                   this.Image1.ImageUrl = "../images/Temp/" + Mpath;
                   Session["imageurl"] = Mpath;
                   LabMessage1.Text = "上传成功！";
                   //LabMessage2.Text = "<b>原文件路径：</b>" + FileUpload1.PostedFile.FileName + "<br />" +
                   //              "<b>文件大小：</b>" + FileUpload1.PostedFile.ContentLength + "字节<br />" +
                   //              "<b>文件类型：</b>" + FileUpload1.PostedFile.ContentType + "<br />";
               }
               catch (Exception ex)
               {
                   LabMessage1.Text = "文件上传不成功.";
               }
           }
           else
           {
               LabMessage1.Text = "只能够上传图片文件.";
           }

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
            moduser.state = "1";
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
            moduser.headImgUrl = "images/Temp/" + Session["imageurl"].ToString ();

            int t = blluser.Add(moduser);
            if (t <= 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language=javascript>alert('保存失败，请重新输入！');</script> ", false);

            }
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language=javascript>alert('保存成功！');</script> ", false);

            this.txtaddr.Text = "";
            this.txtage.Text = "";
            this.txtcol.Text = "";
            this.txtmid.Text = "";
            this.txtpri.Text = "";
            this.txtsenior.Text = "";

        }

      

       


    
    }
}