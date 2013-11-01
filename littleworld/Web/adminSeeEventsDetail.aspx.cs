using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace littleworld.Web
{
    public partial class adminSeeEventsDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int operatorIDs = Convert.ToInt32(Request.QueryString["EventsID"]);
            BLL.eventsTb bllevent = new BLL.eventsTb();
            Model.eventsTb modevent = bllevent.GetModel(operatorIDs);
            this.labelContent.Text = modevent.operateContent ;
            this.labelID.Text = modevent.ID .ToString ();
            this.labelTime.Text = modevent.operateTime.ToString();
            BLL.userTb bllUser = new BLL.userTb();
            Model.userTb user = bllUser.GetModel(modevent .operatorID );
            this.labelSenderName.Text = user.userName;
            this.labelType.Text = modevent.operateAction;
            this.userImgs .InnerHtml  ="<img src='"+user.headImgUrl+"' />";
            this.labeloperatorID.Text = user.userID.ToString ();
        }
    }
}