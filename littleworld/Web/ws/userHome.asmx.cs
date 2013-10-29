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
        public string Addinfo(string sendID)
        {

            BLL.userTb bll_user = new BLL.userTb();
            Model.userTb mod_user = new Model.userTb();
            BLL.fansTb bll_fans = new BLL.fansTb();
            List<Model.fansTb> Guanzhu = bll_fans.GetModelList("ownID='" + sendID + "'");
            BLL.noveltyTb bll_nov = new BLL.noveltyTb();
            List<Model.noveltyTb> mod_novlist = new List<Model.noveltyTb>();
            string fans = Guanzhu.Count + "%";
            
            for (int i = 0; i < Guanzhu.Count(); i++)
            {
                mod_user = bll_user.GetModel(Guanzhu[i].ownedID);
                mod_novlist = bll_nov.GetModelList("senderID='" +Guanzhu[i].ownedID + "'");
                int index = mod_novlist.Count();//某好友新鲜事总数
                fans += index+"#+#";
                for (int j = 0; j < index; j++)
                {
                    fans+=Guanzhu[i].ownedName+";"+mod_novlist[j].contents+";"+mod_novlist[j].publishtime.ToString()+";"+mod_novlist[j].supportNum.ToString()+";"+mod_novlist[j].transmitNum.ToString()+";"+mod_novlist[j].commentNum.ToString()+";"+mod_user.headImgUrl+";"+mod_novlist[j].noveltyID.ToString()+"!=!";
                }
                fans+="@";

            }
            
            return fans;

        }



        [WebMethod]
        public string AddNews(int sendID,string state,string txtcomment,string paths)
        {
            string[] s = paths.Split(';');

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
           
            mod_notb.commentNum = 0;
            mod_notb.supportNum = 0;
            mod_notb.reportNum = 0;
            mod_notb.transmitNum = 0;
            mod_notb.publishtime = DateTime.Now;
           
            bll_notb.Add(mod_notb);

            int maxID=bll_notb.GetMaxId()-1;

            BLL.noveltyImagesTb bll_noImg = new BLL.noveltyImagesTb();
            Model.noveltyImagesTb mod_Img = new Model.noveltyImagesTb();
            for (int i = 0; i < s.Length-1; i++)
            {

                mod_Img.noveltyID = maxID;
                mod_Img.imgUrl = s[i];
                mod_Img.smallImgUrl = s[i];
                bll_noImg.Add(mod_Img);
            }



            return "添加成功";

        }
    }
}
