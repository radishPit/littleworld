using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.SessionState;
namespace littleworld.Web
{
    /// <summary>
    /// UploadHandler 的摘要说明
    /// </summary>
    /// //
    public class UploadHandler : IHttpHandler
    {  
            
        public void ProcessRequest(HttpContext context)
        {
           
            context.Response.ContentType = "text/plain";
            context.Response.Charset = "utf-8";

            HttpPostedFile file = context.Request.Files["Filedata"];
            string uploadPath =
                HttpContext.Current.Server.MapPath(@context.Request["folder"]) + "//";

            if (file != null)
            {
                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }
                string trueFileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                file.SaveAs(uploadPath + trueFileName);
                //将图片保存到数据库
                //BLL.photoTb bllphoto = new BLL.photoTb();
                //Model.photoTb modphoto = new Model.photoTb();
                //modphoto.imgUrl = uploadPath.ToString() + trueFileName.ToString();
                //modphoto.ownID = 5;
                
                //modphoto.photoGroupID = int.Parse(context.Session["AlbumID"].ToString());
                //modphoto.description = "无描述";
                //modphoto.creatTime = DateTime.Now;
                //bllphoto.Add(modphoto);
                //下面这句代码缺少的话，上传成功后上传队列的显示不会自动消失
                context.Response.Write("1");
            }
            else
            {
                context.Response.Write("0");
            }  
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}