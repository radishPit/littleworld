using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
namespace littleworld.Web
{
    public partial class adminNoveltyDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int noveltyID =Convert.ToInt32(Request.QueryString["noveltyID"]);
            BLL.noveltyTb bllNovelty = new BLL.noveltyTb();
            Model.noveltyTb novelty = bllNovelty.GetModel(noveltyID);
            this.labelcommentNum.Text = novelty.commentNum.ToString();
            this.labelContent.Text = novelty.contents;
            this.labelID.Text = novelty.noveltyID.ToString();
            this.labelpublishTime.Text = novelty.publishtime.ToString();
            this.labelreportNum.Text = novelty.reportNum.ToString();
            BLL.userTb bllUser=new BLL.userTb();
            Model.userTb user=bllUser.GetModel(novelty.senderID);
            this.labelSenderName.Text = user.userName;
            this.labelsupportNum.Text = novelty.supportNum.ToString();
            this.labeltransmitNum.Text = novelty.transmitNum.ToString();
            BLL.noveltyGroupTb bllnoveltyGroup = new BLL.noveltyGroupTb();
            Model.noveltyGroupTb noveltyGroup = bllnoveltyGroup.GetModel(Convert.ToInt32(novelty.typeID));
            this.labelType.Text = noveltyGroup.noveltyGroupName;
            if (novelty.hasImgs == 1)
            {
                BLL.noveltyImagesTb bllNoveltyImages = new BLL.noveltyImagesTb();
                List<Model.noveltyImagesTb> noveltyImgs = bllNoveltyImages.GetModelList("noveltyID=" + novelty.noveltyID);
                StringBuilder html = new StringBuilder("");
                this.noveltyImgs.InnerHtml = "";
                foreach (var noveltyImg in noveltyImgs)
                {
                    html.Append("<img src='" + noveltyImg.smallImgUrl + "' />");
                }
                this.noveltyImgs.InnerHtml = html.ToString();
            }
            else
            {
                this.noveltyImgs.InnerHtml = "无图片";
            }
        }
    }
}