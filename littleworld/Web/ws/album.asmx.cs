﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace littleworld.Web.ws
{
    /// <summary>
    /// album 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    [System.Web.Script.Services.ScriptService]
    public class album : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public List<Model.photoGroupTb> showAlum(int userid) {
            BLL.photoGroupTb myphotos = new BLL.photoGroupTb();
            List<Model.photoGroupTb> modphoto = myphotos.GetModelList("ownID='"+userid+"'");
            return modphoto;
        }
    }
}
