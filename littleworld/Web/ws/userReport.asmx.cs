using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace littleworld.Web.ws
{
    /// <summary>
    /// userReport 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
     [System.Web.Script.Services.ScriptService]
    public class userReport : System.Web.Services.WebService
    {

        [WebMethod]
        public void InsertReport(int noveltyid,int reporeterid,DateTime reporttime,int reporttypeid,string state)
        {
            BLL.reportTb bll = new BLL.reportTb();
            Model.reportTb ml = new Model.reportTb();
            ml.noveltyID = noveltyid;
            ml.reporterID = reporeterid;
            ml.reportTime = reporttime;
            ml.reportTypeID = reporttypeid;
            ml.state = state;
            bll.Add(ml);
        }
    }
}
