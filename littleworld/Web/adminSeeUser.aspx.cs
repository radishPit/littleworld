﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace littleworld.Web
{
    public partial class adminSeeUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["pageInd"] == null)
            {
                bindData(0, "1=1");
            }
            else
            {
                int pageInde = Convert.ToInt32(Request.QueryString["pageInd"]);
                bindData(pageInde, "1=1");
            }
        }
        public void bindData(int pageIn, string selectWhere)
        {
            BLL.userTb blluser = new BLL.userTb();
            List<Model.userTb> users = blluser.GetModelList(selectWhere);
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = users;
            pds.PageSize = 8;
            pds.AllowPaging = true;
            pds.CurrentPageIndex = pageIn;
            this.gvSuperAdminSeeInfo.DataSource = pds;
            this.gvSuperAdminSeeInfo.DataBind();

            int pageCount = pds.PageCount;
            StringBuilder html = new StringBuilder("");
            html.Append("<a class='pageA pageStart pageA0' href='adminSeeUser.aspx?pageInd=0'>首页</a>");
            for (int i = 0; i < pageCount; i++)
            {
                html.Append("<a class='pageA pageNum pageA" + i.ToString() + "' href='adminSeeUser.aspx?pageInd=" + i.ToString() + "'>" + (i + 1).ToString() + "</a>");
            }
            html.Append("<a class='pageA pageStart pageA"+(pageCount-1).ToString()+"' href='adminSeeUser.aspx?pageInd=" + (pageCount - 1).ToString() + "'>尾页</a>");
            this.dgvpage.InnerHtml = html.ToString();
            ScriptManager.RegisterStartupScript(searchBtn, this.GetType(), "clickPage", "clickPage(" + pageIn.ToString() + ");", true);

        }


        protected void gvSuperAdminSeeInfo_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType != DataControlRowType.DataRow)
            {
                return;
            }
            e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='#ffffcf'");
            if (e.Row.RowIndex % 2 == 0)
            {
                e.Row.CssClass = "gvSuperAdminSeeInfoORow";
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#fff'");
            }
            else
            {
                e.Row.CssClass = "gvSuperAdminSeeInfoJRow";
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#f5f5f5'");
            }
        }

        protected void search_Click(object sender, EventArgs e)
        {
            string searchT = this.searchText.Text;
            if (searchT == "")
            {
                ScriptManager.RegisterStartupScript(searchBtn, this.GetType(), "showErrorAlert", "showErrorAlert('请输入关键字！');", true);
                return;
            }
            try
            {
                BLL.userTb blluserTb = new BLL.userTb();
                List<Model.userTb> users = blluserTb.GetModelList("userID like '%" + searchT + "%'");
                if (users.Count == 0)
                {
                    ScriptManager.RegisterStartupScript(searchBtn, this.GetType(), "showNoticeAlert", "showNoticeAlert('没有您要找的用户！');", true);
                    return;
                }
                bindData(0, "userID like '%" + searchT + "%'");
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(searchBtn, this.GetType(), "showErrorAlert", "showErrorAlert('发生错误,请重新输入关键字！');", true);
            }
        }
        public string showuserState(string state) {
            if (state==null)
            {
                return "封锁";
            }
            string nowState;
            switch (state) {
                case "0": nowState = "解封"; break;
                case "1": nowState = "封锁"; break;
                default: nowState = "封锁"; break;
            }
            return nowState;
        }
    }
}