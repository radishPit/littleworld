using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace littleworld.Web
{
    public partial class adminSeeEvents : System.Web.UI.Page
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
            BLL.eventsTb blluser = new BLL.eventsTb();
            List<Model.eventsTb> users = blluser.GetModelList(selectWhere);
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = users;
            pds.PageSize = 10;
            pds.AllowPaging = true;
            pds.CurrentPageIndex = pageIn;
            this.GridView1.DataSource = pds;
            this.GridView1.DataBind();

            int pageCount = pds.PageCount;
            StringBuilder html = new StringBuilder("");
            html.Append("<a class='pageA pageStart pageA0' href='adminSeeEvents.aspx?pageInd=0'>首页</a>");
            for (int i = 0; i < pageCount; i++)
            {
                html.Append("<a class='pageA pageNum pageA" + i.ToString() + "' href='adminSeeEvents.aspx?pageInd=" + i.ToString() + "'>" + (i + 1).ToString() + "</a>");
            }
            html.Append("<a class='pageA pageStart pageA" + (pageCount - 1).ToString() + "' href='adminSeeEvents.aspx?pageInd=" + (pageCount - 1).ToString() + "'>尾页</a>");
            this.dgvpage.InnerHtml = html.ToString();
            ScriptManager.RegisterStartupScript(searchBtn, this.GetType(), "clickPage", "clickPage(" + pageIn.ToString() + ");", true);

        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
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

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            string searchT = this.searchText.Text;
            if (searchT == "")
            {
                ScriptManager.RegisterStartupScript(searchBtn, this.GetType(), "showErrorAlert", "showErrorAlert('请输入关键字！');", true);
                return;
            }
            try
            {
                BLL.eventsTb bllnovelTy = new BLL.eventsTb();
                List<Model.eventsTb> noveltys = bllnovelTy.GetModelList("operatorID like '%" + searchT + "%'");
                if (noveltys.Count == 0)
                {
                    ScriptManager.RegisterStartupScript(searchBtn, this.GetType(), "showNoticeAlert", "showNoticeAlert('没有您要找的事务！');", true);
                    return;
                }
                bindData(0, "operatorID like '%" + searchT + "%'");
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(searchBtn, this.GetType(), "showErrorAlert", "showErrorAlert('发生错误,请重新输入关键字！');", true);

            }
        }
    }
}