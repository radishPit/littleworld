using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace littleworld.Web.ws
{
    /// <summary>
    /// superSeeAdminInfo 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    [System.Web.Script.Services.ScriptService]
    public class superSeeAdminInfo : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public void deletAdmin(int adminid) {
            try
            {
                BLL.adminTb bllAdmin = new BLL.adminTb();
                bllAdmin.Delete(adminid); 
            }
            catch (Exception)
            {
                throw;
            }
           
        }
        [WebMethod]
        public List<Model.adminTb> selectAdminName() {
            BLL.adminTb bllAdmin = new BLL.adminTb();
            List<Model.adminTb> admins = bllAdmin.GetModelList("adminLevel=1");
           
            return admins;

        } 
    }
}
