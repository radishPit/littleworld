using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace littleworld.Web.ws
{
    /// <summary>
    /// userHome 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    [System.Web.Script.Services.ScriptService]
    public class userHome : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string PB(string ID,string novID)
        {
            BLL.noveltyTb bll_n = new BLL.noveltyTb();
            Model.noveltyTb mod_n = new Model.noveltyTb();
            mod_n = bll_n.GetModel(Convert.ToInt16(novID));
            BLL.fansTb bll_fan = new BLL.fansTb();
            List<Model.fansTb> mod_fan = new List<Model.fansTb>();
            mod_fan = bll_fan.GetModelList("ownID='"+ID+"'and ownedID='"+mod_n.senderID.ToString()+"'");
            mod_fan[0].groupID = 0;

            bll_fan.Update(mod_fan[0]);
            return mod_fan[0].ownedID.ToString();
        }
        [WebMethod]
        public string AddStore(string novID,string myID)
        {
            BLL.storeTb bll_store = new BLL.storeTb();
            List<Model.storeTb> mod_test = bll_store.GetModelList("noveltyID='"+novID+"'and storerID='"+myID+"'");
            if (mod_test.Count()!=0)
            {
                bll_store.Delete(mod_test[0].ID);
                return "no";
            }
            else
            {
                Model.storeTb mod_store = new Model.storeTb();
                mod_store.noveltyID = Convert.ToInt16(novID);
                mod_store.state = "1";
                mod_store.storeTime = DateTime.Now;
                mod_store.storerID = Convert.ToInt16(myID);
                mod_store.title = "收藏";
                bll_store.Add(mod_store);
                return "yes";
            }
            
        }
       

        [WebMethod]
        public string[] FaceHover(string ID,string me)//获得新鲜事的ID
        {
            string nickname;
           
            BLL.noveltyTb bll_nov=new BLL.noveltyTb();
            Model.noveltyTb mod_nov=new Model.noveltyTb();
            mod_nov=bll_nov.GetModel(Convert.ToInt16(ID));

            BLL.userTb bll_user = new BLL.userTb();
            Model.userTb mod_user = new Model.userTb();
            mod_user = bll_user.GetModel(mod_nov.senderID);

            BLL.fansTb bll_fans=new BLL.fansTb();
            List<Model.fansTb> mod_fan=new List<Model.fansTb>();
            if (me.Equals(mod_nov.senderID.ToString()))
            {
                nickname = mod_user.userName;
            }
            else
            {
                mod_fan = bll_fans.GetModelList("ownID='" + me + "'and ownedID='" + mod_nov.senderID.ToString() + "'");
                nickname = mod_fan[0].ownedName;
            }
            
            List<Model.fansTb> mod_guanzhu = new List<Model.fansTb>();
            mod_guanzhu = bll_fans.GetModelList("ownID='"+me+"'");
            List<Model.fansTb> mod_fans = new List<Model.fansTb>();
            mod_fans = bll_fans.GetModelList("ownedID='" + me + "'");

            List<Model.noveltyTb> noveltys = new List<Model.noveltyTb>();
            noveltys = bll_nov.GetModelList("senderID='"+me+"'");

            string[] arr = new string[8];
            arr[0] = mod_user.userName;
            arr[1] = nickname;
            arr[2] = mod_user.addr;
            arr[3] = mod_user.highSchool;
            arr[4] = mod_guanzhu.Count().ToString();
            arr[5] = mod_fans.Count().ToString();
            arr[6] = noveltys.Count().ToString();
            arr[7] = mod_user.headImgUrl;
            return arr;

        }


        [WebMethod]
        public string HideNov(int noveltyID)
        {
            BLL.noveltyTb bll_nov = new BLL.noveltyTb();
            Model.noveltyTb mod_nov = new Model.noveltyTb();
            mod_nov = bll_nov.GetModel(noveltyID);
            mod_nov.state = "0";
            bll_nov.Update(mod_nov);
            return "1";
            
        }

        [WebMethod]
        public string Addsupport(string novityID,string type,int ID)
        {
            int noID;
            BLL.transmitTb bll_transmit = new BLL.transmitTb();
            BLL.noveltyTb bll_nov = new BLL.noveltyTb();
            BLL.supportTb bll_support = new BLL.supportTb();
            Model.noveltyTb mod_nov = new Model.noveltyTb();
            mod_nov = bll_nov.GetModel(Convert.ToInt16(novityID));
            if (type.Equals("1"))
            {   //新鲜事表操作
               
                //赞表操作
                List<Model.supportTb> temp=new List<Model.supportTb>();
                temp= bll_support.GetModelList("noveltyID='" +novityID + "'and suppoterID='" + ID.ToString() + "'");
                
                 if (temp.Count() == 0)
                 {
                     Model.supportTb mod_sup = new Model.supportTb();
                     mod_sup.noveltyID = (Convert.ToInt16(novityID));
                     mod_sup.state = "1";
                     mod_sup.suppoterID = ID;
                     mod_sup.suppotTime = DateTime.Now;
                     bll_support.Add(mod_sup);

                     noID = Convert.ToInt16(mod_nov.supportNum);
                     noID++;
                     mod_nov.supportNum = noID;
                     bll_nov.Update(mod_nov);
                     string str="1"+"@=@"+noID.ToString();
                     return str;
                 }
                 else//找到
                 {

                     noID = Convert.ToInt16(mod_nov.supportNum);
                     noID--;
                     mod_nov.supportNum = noID;
                     bll_nov.Update(mod_nov);
                     bll_support.Delete(temp[0].ID);
                     string str = "-1" + "@=@" + noID.ToString();
                     return str;
                 }
                
                
            }
            else
            {
                //转发微博操作
                //新鲜事表操作
                noID = Convert.ToInt16(mod_nov.transmitNum);
                noID++;
                mod_nov.transmitNum = noID;
                bll_nov.Update(mod_nov);

                //添加转发新鲜事
                Model.noveltyTb news= new Model.noveltyTb();
                news.senderID = ID;
                news.noveltyID = bll_nov.GetMaxId();
                news.hasImgs = 0;
                news.publishtime = DateTime.Now;
                news.reportNum = 0;
                news.state = "1";
                news.supportNum = 0;
                news.transmitNum = 0;
                news.typeID = 1;
                news.contents = "转发微博";
                bll_nov.Add(news);
                //转发表操作


                Model.transmitTb mod_tr = new Model.transmitTb();
                mod_tr.noveltyID = Convert.ToInt16(novityID);
                mod_tr.power = 1;
                mod_tr.state = "1";
                mod_tr.transmiterID = mod_nov.senderID;
                mod_tr.transmitTime = DateTime.Now;
                mod_tr.contents = mod_nov.contents;
                bll_transmit.Add(mod_tr);

                Model.userTb user = new Model.userTb();
                BLL.userTb bll_user = new BLL.userTb();
                user = bll_user.GetModel(ID);

                List<Model.fansTb> mod_fan = new List<Model.fansTb>();
                BLL.fansTb bll_fan = new BLL.fansTb();
                mod_fan = bll_fan.GetModelList("ownedID='"+mod_nov.senderID.ToString()+"'and ownID='"+user.userID.ToString()+"'");
                string trString = "";

                trString = noID.ToString() + "@=@" + user.userName + ";" + news.contents + ";" + news.publishtime.ToString() + ";" + news.supportNum.ToString() + ";" + news.transmitNum.ToString() + ";" + news.commentNum.ToString() + ";" + user.headImgUrl + ";" + news.noveltyID.ToString();

                return trString;
            }
            

        }
        [WebMethod]
        public List<noveltyInfo> Addinfo(string sendID)
        {
            List<noveltyInfo> novs = new List<noveltyInfo>();
            BLL.userTb bll_user = new BLL.userTb();
            BLL.fansTb bll_fans = new BLL.fansTb();
            List<Model.fansTb> Guanzhu = bll_fans.GetModelList("ownID='" + sendID + "'and groupID!=-1 ");
            //List<int> list = new List<int>();
            //foreach (Model.fansTb fan in Guanzhu)
            //{
            //    list.Add(fan.ownedID);
            //}

            BLL.noveltyTb bll_nov = new BLL.noveltyTb();
            List<Model.noveltyTb> mod_novlist = new List<Model.noveltyTb>();
            List<Model.noveltyTb> mod_alllist = new List<Model.noveltyTb>();
            for (int i = 0; i < Guanzhu.Count(); i++)
            {
                mod_novlist = bll_nov.GetModelList("senderID='" + Guanzhu[i].ownedID + "'and state=1");
                mod_alllist.AddRange(mod_novlist);
            }
            List<Model.noveltyTb> mod_melist = new List<Model.noveltyTb>();
            mod_melist = bll_nov.GetModelList("senderID='" + sendID + "'and state=1");
            mod_alllist.AddRange(mod_melist);
            Model.noveltyTb temp = new Model.noveltyTb();
            for (int i = 0; i < mod_alllist.Count() - 1; i++)
            {
                for (int j = i + 1; j < mod_alllist.Count(); j++)
                {
                    if (mod_alllist[i].noveltyID < mod_alllist[j].noveltyID)
                    {
                        temp = mod_alllist[i];
                        mod_alllist[i] = mod_alllist[j];
                        mod_alllist[j] = temp;
                    }
                }
            }
           
            //string all_novety = "";
            //all_novety += mod_alllist.Count().ToString() + "@+@";
            for (int i = 0; i < mod_alllist.Count(); i++)
            {
                
                Model.userTb mod_user = new Model.userTb();
                mod_user = bll_user.GetModel(mod_alllist[i].senderID);

                
                List<Model.fansTb> mod_f = new List<Model.fansTb>();
                mod_f = bll_fans.GetModelList("ownID='"+sendID+"'and ownedID='"+mod_user.userID.ToString()+"'");

                noveltyInfo nov = new noveltyInfo();
                if (mod_user.userID == Convert.ToInt16(sendID))
                {
                    nov.UserName =mod_user.userName;
                }
                else
                {
                    nov.UserName = mod_f[0].ownedName;
                }
                nov.TypeID =Convert.ToInt16(mod_alllist[i].typeID);
                nov.Supportnum =Convert.ToInt16(mod_alllist[i].supportNum);
                nov.Transmitnum = Convert.ToInt16(mod_alllist[i].transmitNum);
                nov.Headurl = mod_user.headImgUrl;
                nov.Time = mod_alllist[i].publishtime.ToString();
                nov.Commentnum =Convert.ToInt16(mod_alllist[i].commentNum);
                nov.Contents = mod_alllist[i].contents;
                nov.NovID = mod_alllist[i].noveltyID;
                novs.Add(nov);
            
            }
            return novs;

            //return all_novety;


        }


        [WebMethod]
        public string AddNews(int sendID,string state,string txtcomment,string paths)
        {
            string[] s = paths.Split(';');
            BLL.userTb bll_user = new BLL.userTb();
            Model.userTb me = new Model.userTb();
            me = bll_user.GetModel(sendID);

            //添加文字
            BLL.noveltyTb bll_notb = new BLL.noveltyTb();
            Model.noveltyTb mod_notb = new Model.noveltyTb();
            mod_notb.senderID = sendID;
            mod_notb.contents = txtcomment;
           
            mod_notb.state = state;
            if (s.Length == 1)
            {
                mod_notb.hasImgs = 0;
            }
            else {
                mod_notb.hasImgs = 1;
            }
            mod_notb.typeID = 1;
            mod_notb.commentNum = 0;
            mod_notb.supportNum = 0;
            mod_notb.reportNum = 0;
            mod_notb.transmitNum = 0;
            mod_notb.publishtime = DateTime.Now;
           
            bll_notb.Add(mod_notb);
           
            int maxID=bll_notb.GetMaxId()-1;

            BLL.noveltyImagesTb bll_noImg = new BLL.noveltyImagesTb();
            Model.noveltyImagesTb mod_Img = new Model.noveltyImagesTb();
            for (int i = 0; i < s.Length - 1; i++)
            {

                mod_Img.noveltyID = maxID;
                mod_Img.imgUrl = s[i];
                mod_Img.smallImgUrl = s[i];
                bll_noImg.Add(mod_Img);
            }
            string new_novelty = "";
            new_novelty += me.userName.ToString() + ";" + mod_notb.contents + ";" + mod_notb.publishtime.ToString() + ";" + mod_notb.supportNum.ToString() + ";" + mod_notb.transmitNum.ToString() + ";" + mod_notb.commentNum.ToString() + ";" + me.headImgUrl + ";" + maxID + ";";
            
            return new_novelty;
            

        }
    }
}
