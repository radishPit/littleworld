using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace littleworld.Web
{
    public partial class userHome : System.Web.UI.Page
    {
        private int _myID;

        public int MyID
        {
            get { return _myID; }
            set { _myID = value; }
        }
      
        protected void Page_Load(object sender, EventArgs e)
        {
            string myEmail = Session["no"].ToString();
            string myname;
            string fansnum;
            string noveltynum;
            string guanzhunum;
            string myImg;
            //int myID;

            //int myID = 5;
            BLL.userTb bll_user = new BLL.userTb();
            Model.userTb me = new Model.userTb();
            List<Model.userTb> myspace = new List<Model.userTb>();
            myspace = bll_user.GetModelList("userEmail='" + myEmail + "'");
            me = myspace[0];
            //me = bll_user.GetModel(myID);
            MyID = me.userID;
            myname = me.userName;
            myImg = me.headImgUrl;

            BLL.fansTb bll_fans = new BLL.fansTb();
            List<Model.fansTb> fans = new List<Model.fansTb>();
            fans = bll_fans.GetModelList("ownedID='" + MyID.ToString() + "'");
            fansnum = fans.Count().ToString();

            BLL.noveltyTb bll_noveltyTb = new BLL.noveltyTb();
            List<Model.noveltyTb> novs = new List<Model.noveltyTb>();
            novs = bll_noveltyTb.GetModelList("senderID='" + MyID.ToString() + "'");
            noveltynum = novs.Count().ToString();

            BLL.fansTb bll_guanzhu = new BLL.fansTb();
            List<Model.fansTb> guanzhus = new List<Model.fansTb>();
            guanzhus = bll_guanzhu.GetModelList("ownID='" + MyID.ToString() + "'");
            guanzhunum = guanzhus.Count().ToString();

            this.myImg.Src = myImg;
            this.myname.InnerText = myname;
            this.noveltynum.InnerHtml = noveltynum;
            this.fansnum.InnerText = fansnum;
            this.guanzhunum.InnerText = guanzhunum;
            


            //Session.Remove("no");
            //Session.Remove("pwd");
        }

       
       
        
       

    }
}