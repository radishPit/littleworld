﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Media;
using System.IO;

namespace littleworld.Web
{
    public partial class adminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {

            string no = this.txtQ.Text.ToString();
            string pwd = this.pwdQ.Text.ToString();
            BLL.adminTb blladmin = new BLL.adminTb();
            if (no == "" || pwd == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language=javascript>alert('用户名与密码不能为空，请重新输入！');</script>", false);
                return;
            }

           
            List<Model.adminTb> modadmin = blladmin.GetModelList("adminName='" + no + "'");
            //modadmin = blladmin.GetModel(Convert.ToInt32(no));
            foreach(Model.adminTb modadmin1 in modadmin )
            {
                if (modadmin1.adminPwd != pwd)
                {
                    //this.txtQ.Text = "";
                    this.pwdQ.Text = "";
                    Page.ClientScript.RegisterStartupScript(this.GetType (),"","<script type='text/javascript'>alert('用户名与密码不匹配，请重新输入！');</script>",false);
                    return;
                }

                Session["no"] = no;
                Session["pwd"] = pwd;
                if (modadmin1.adminLevel == 0)
                {
                    Response.Redirect("superSeeAdminInfo.aspx");
                }
                else
                {
                    Response.Redirect("adminModifyInfo.aspx");
                }
            }

            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('账号不存在，请重新输入！');</script>", false);
            this.txtQ.Text  = "";
            this.pwdQ.Text = "";

        }










    }
}