using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace littleworld.Web
{
    public partial class userSpace1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            BLL.userTb user=new BLL.userTb();
            Model.userTb moduser=user.GetModel(5);
            this.lblname.Text = moduser.userName.ToString();
            string sax = moduser.sex.ToString();
            if (sax == "女")
            {
                this.imgsax.ImageUrl = "../images/userSpaceImg/girl.gif";
            }
            else
            {
                this.imgsax.ImageUrl = "../images/userSpaceImg/boy.gif";

            }
            this.state.InnerText = moduser.addr.ToString();
            this.conlege.InnerText = moduser.collegeSchool.ToString();
            this.imghead.ImageUrl = moduser.headImgUrl.ToString();
           
           

            BLL.fansTb bllfans = new BLL.fansTb();
            List<Model.fansTb> myattention = bllfans.GetModelList("ownID=5");
            int attention = 0;
            foreach (Model.fansTb item in myattention)
            {
                attention++;

            }
            this.lblattention.Text = attention.ToString();

            List<Model.fansTb> myfans = bllfans.GetModelList("ownedID=5");
            int fans = 0;
            foreach (Model.fansTb i in myfans)
            {
                fans++;
            }
            this.lblfans.Text = fans.ToString();

            BLL.noveltyTb bllnov = new BLL.noveltyTb();
            List<Model.noveltyTb> mynov = bllnov.GetModelList("senderID=5");
            int news = 0;
            foreach (Model.noveltyTb n in mynov)
            {
                news++;
            }
            this.lblnews.Text = news.ToString();
        }
    }
}