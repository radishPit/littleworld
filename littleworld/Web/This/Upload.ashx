<%@ WebHandler Language="C#" Class="Upload" %>

using System;
using System.Web;
using System.IO;

public class Upload : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        context.Response.Expires = -1;
        try
        {
            HttpPostedFile postedFile = context.Request.Files["Filedata"];
            
            string savepath = "";
            string tempPath = "";
            tempPath = System.Configuration.ConfigurationManager.AppSettings["FolderPath"]; 
            savepath = context.Server.MapPath(tempPath);
            string filename = postedFile.FileName;
            if (!Directory.Exists(savepath))
                Directory.CreateDirectory(savepath);
            filename= Guid.NewGuid().ToString() + Path.GetExtension(filename);
            string res = tempPath+ @"/" +filename;
            postedFile.SaveAs(savepath + @"\" + filename);
            context.Response.Write(res);
            context.Response.StatusCode = 200;

           
            
        }
        catch (Exception ex)
        {
            context.Response.Write("Error: " + ex.Message);
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }
}