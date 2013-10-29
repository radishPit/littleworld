using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace littleworld.Web.ws
{
    /// <summary>
    /// userMassage 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    //若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
     [System.Web.Script.Services.ScriptService]
    public class userMassage : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Model.getmessage > Getmessage(int userid) {
            BLL.fansTb bllfan = new BLL.fansTb();
            List<Model.fansTb> mfan = bllfan.GetModelList("ownID="+ userid );
            BLL.noveltyTb bllnov = new BLL.noveltyTb();
            List<Model.noveltyTb> mon = new List<Model.noveltyTb>();
            List<Model.getmessage> mg = new List<Model.getmessage>();
            foreach (Model.fansTb mf in mfan)
            {

                mon = bllnov.GetModelList("senderID=" + mf.ownedID);               
               
                if (mon.Count>=0)
                {
                    for (int j = 0; j <mon.Count; j++)
                    {
                      
                        Model.getmessage mgetm = new Model.getmessage();
                        mgetm.Id = mon[j].senderID;
                        mgetm.Contents = mon[j].contents;
                        mgetm.Publishtime = mon[j].publishtime;
                        BLL.userTb bllu = new BLL.userTb();
                        Model.userTb muser = bllu.GetModel(mon[j].senderID);
                        mgetm.HeadimgUrl = muser.headImgUrl;
                        mgetm.OwnedName = muser.userName;
                        mg.Add(mgetm);
                    }
                }
              

            }
        

         

            return mg;

        }
    }
}
