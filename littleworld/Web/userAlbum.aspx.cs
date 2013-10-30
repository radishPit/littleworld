using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace littleworld.Web
{
    public partial class userAlbum : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            int a = 5;
            BLL.photoGroupTb bllphoto = new BLL.photoGroupTb();
            List<Model.photoGroupTb> modphoto = bllphoto.GetModelList("ownID="+a);
            foreach (Model.photoGroupTb myphoto in modphoto)
            {
              //myphoto.ownID
            }
        }
    }
}