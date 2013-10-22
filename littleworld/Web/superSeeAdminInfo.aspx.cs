using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace littleworld.Web
{
    public partial class superSeeAdminInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.adminTb bllAdmin = new BLL.adminTb();
            List<Model.adminTb> admins = bllAdmin.GetModelList("adminLevel=1");
            this.gvSuperAdminSeeInfo.DataSource=admins;
            this.gvSuperAdminSeeInfo.DataBind();
        }

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
    }
}