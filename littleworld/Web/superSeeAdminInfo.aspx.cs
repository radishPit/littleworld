﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
namespace littleworld.Web
{
    public partial class superSeeAdminInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["pageInd"] == null)
            {
                bindData(0, "adminLevel=1 and adminName like '%1%'");
            }
            else 
            {
                int pageInde = Convert.ToInt32(Request.QueryString["pageInd"]);
                bindData(pageInde, "adminLevel=1 and adminName like '%1%'");
            }    
        }
        public void bindData(int pageIn,string selectWhere) 
        {
            BLL.adminTb bllAdmin = new BLL.adminTb();
            List<Model.adminTb> admins = bllAdmin.GetModelList(selectWhere);
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = admins;
            pds.PageSize =6;
            pds.AllowPaging = true;
            pds.CurrentPageIndex = pageIn;
            this.gvSuperAdminSeeInfo.DataSource = pds;
            this.gvSuperAdminSeeInfo.DataBind();

            int pageCount = pds.PageCount;
            StringBuilder html = new StringBuilder("");
            html.Append("<a class='pageA pageStart' href='superSeeAdminInfo.aspx?pageInd=0'>首页</a>");
            for (int i = 0; i < pageCount; i++)
            {
                html.Append("<a class='pageA pageNum pageA"+(i+1).ToString()+"' href='superSeeAdminInfo.aspx?pageInd=" + i.ToString() + "'>" + (i + 1).ToString() + "</a>");
            }
            html.Append("<a class='pageA pageStart' href='superSeeAdminInfo.aspx?pageInd=" + (pageCount - 1).ToString() + "'>尾页</a>");
            this.dgvpage.InnerHtml = html.ToString();
            ScriptManager.RegisterStartupScript(searchBtn, this.GetType(), "clickPage", "clickPage("+(pageIn+1).ToString()+");", true);
                
        }
        //public void showAdmins()
        //{
        //    BLL.adminTb bllAdmin = new BLL.adminTb();
        //    List<Model.adminTb> admins = bllAdmin.GetModelList("adminLevel=1");
        //    this.gvSuperAdminSeeInfo.DataSource = admins;
        //    this.gvSuperAdminSeeInfo.DataBind();
        //}

        protected void gvSuperAdminSeeInfo_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType!= DataControlRowType.DataRow)
            {
                return;
            }
            e.Row.Attributes.Add("onmouseover","this.style.backgroundColor='#ffffcf'");
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
            if (searchT=="")
            {
                ScriptManager.RegisterStartupScript(searchBtn, this.GetType(), "showErrorAlert", "showErrorAlert('请输入关键字！');", true);
                return;
            }
            try
            {
                BLL.adminTb bllAdmin = new BLL.adminTb();
                List<Model.adminTb> admins = bllAdmin.GetModelList("adminLevel=1 and adminName like '%" + searchT + "%'");
                if (admins.Count == 0)
                {
                    ScriptManager.RegisterStartupScript(searchBtn, this.GetType(), "showNoticeAlert", "showNoticeAlert('没有您要找的管理员！');", true);
                    return;
                }
                //ScriptManager.RegisterStartupScript(searchBtn, this.GetType(), "showErrorAlert", "showErrorAlert('输入关键字"+searchT+"！');", true);   
                bindData(0, "adminLevel=1 and adminName like '%"+searchT+"%'");
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(searchBtn, this.GetType(), "showErrorAlert", "showErrorAlert('发生错误,请重新输入关键字！');", true);    
            }  
        }
    }
}