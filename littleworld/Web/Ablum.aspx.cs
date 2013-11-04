using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI.HtmlControls;
namespace littleworld.Web
{
    public partial class Ablum : System.Web.UI.Page
    {
        public int ownID;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["ownID"] = ownID;
            this.selectalbum.Items.Clear();
            ownID = int.Parse(Request.QueryString["userid"]);
             BLL.photoGroupTb myphotos = new BLL.photoGroupTb();
             List<Model.photoGroupTb> modphoto = myphotos.GetModelList("ownID='" + ownID + "'");
             foreach (Model.photoGroupTb myalbum in modphoto)
             {
                 int count=0;
                 BLL.photoTb photos = new BLL.photoTb();
                 List<Model.photoTb> modpic = photos.GetModelList("photoGroupID='"+myalbum.photoGroupID+"'");
                 foreach (Model.photoTb pics in modpic)
                 {
                     count++;
                 }
                 this.selectalbum.Items.Add(myalbum.groupName.ToString());
              
              }
           
      
        }
      
        protected void btnOK_Click(object sender, EventArgs e)
        {
            this.lblnull.Text = "";
            string albumname = this.inputname.Value;
            int ownIDs = int.Parse(Request.QueryString["userid"]);

            if (albumname == "")
            {
                this.lblnull.Text = "请输入专辑名！";
            } else {

                BLL.photoGroupTb bllgroup = new BLL.photoGroupTb();
                List<Model.photoGroupTb> selectgroup = bllgroup.GetModelList("groupName='" + albumname + "'and ownID='" + ownIDs+"'");
                if (selectgroup.Count == 0)
                {
                    Model.photoGroupTb modgroup = new Model.photoGroupTb();
                    modgroup.groupName = albumname;
                    modgroup.ownID = ownIDs;
                    bllgroup.Add(modgroup);
                    this.selectalbum.Items.Add(modgroup.groupName.ToString() + "(共" + 0 + "张)");
                }
                else {
                    this.lblnull.Text = "专辑已存在";
                
                }
               
               
            }
           
        }
        protected void btnCancle_Click(object sender, EventArgs e)
        {
            this.inputname.Value = "";
        
        
        }

        protected void selectalbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Album = "";
           
            Album = this.selectalbum.SelectedValue.ToString();
            BLL.photoGroupTb bllgroup = new BLL.photoGroupTb();
            List<Model.photoGroupTb> modgroup = bllgroup.GetModelList("groupName="+Album);
            foreach (Model.photoGroupTb t in modgroup)
            {
                Session["AlbumID"] = t.photoGroupID;
                Response.Write(Album);

            
            }
        }

        protected void selectalbum_TextChanged(object sender, EventArgs e)
        {
            string Album = "";

            Album = this.selectalbum.SelectedValue.ToString();
            Response.Write(Album);
            BLL.photoGroupTb bllgroup = new BLL.photoGroupTb();
            List<Model.photoGroupTb> modgroup = bllgroup.GetModelList("groupName=" + Album);
            foreach (Model.photoGroupTb t in modgroup)
            {
                Session["AlbumID"] = t.photoGroupID;
               


            }
        }
    }
}