using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace littleworld.Web
{
    public partial class userReport : System.Web.UI.Page
    {
        public int noveltyID = 61;
        public string contents = "";
        public int senderID;
        public string userName = "";
        public string headImgUrl = "";
        protected void Page_Load(object sender, EventArgs e)
        {
             //noveltyID = Request.QueryString.Get("noveltyID");
            getuserinfo();
        }
        public void getuserinfo()
        {
            BLL.noveltyTb bll = new BLL.noveltyTb();
            Model.noveltyTb ml = bll.GetModel(noveltyID);
            contents = ml.contents;
            senderID = ml.senderID;
            BLL.userTb bllu = new BLL.userTb();
            Model.userTb mlu = bllu.GetModel(senderID);
            userName=mlu.userName;
            headImgUrl = mlu.headImgUrl;
        }
    }
}