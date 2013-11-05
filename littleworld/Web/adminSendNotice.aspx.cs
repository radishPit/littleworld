using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace littleworld.Web
{
    public partial class adminSendNotice : System.Web.UI.Page
    {
          public int loginid=1;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.successlbl.Visible = false;
            //loginid = Convert.ToInt32(Session["no"].ToString());
        }

        protected void btnsure_Click(object sender, EventArgs e)
        {

            BLL.noticeTb bllntb = new BLL.noticeTb();
            Model.noticeTb modelntb = new Model.noticeTb();
            modelntb.adminID = 1;
            modelntb.title=this.txttitle.Text;
            modelntb.contents = this.bjtztxt.Text;
            modelntb.sentTime = System.DateTime.Now;
            modelntb.receiveID=Convert.ToInt32(this.DropDownListusers.Text);
            bllntb.Add(modelntb);
            this.lblqf.Visible = false;
            this.successlbl.Visible = true;
           /* this.lblqf.Visible = false;
            this.successlbl.Visible = true;
            string tilte = this.txttitle.Text;
            string contect = this.bjtztxt.Text;
            string receiveid = this.DropDownListusers.Text;
            string mystring = "server=192.168.168.100;database=RP_littleworld;uid=sa;pwd=cslg";
            SqlConnection scon = new SqlConnection(mystring);
            string mysql = @"insert into noticeTb(adminID,title,contents,sentTime,receiveID) values('" + abc.ToString()+"','" + tilte + "' , '" + contect + "' , '" + System.DateTime.Now + "' , '" + receiveid + "' )";
            SqlCommand scom = scon.CreateCommand();
            scom.CommandText = mysql;
            scon.Open();
            scom.ExecuteNonQuery();
            scon.Close(); */
        }

        protected void btnsureall_Click(object sender, EventArgs e)
        {
            this.successlbl.Visible = false;
            this.lblqf.Visible = true;
            string tilte = this.txttitle.Text;
            string contect = this.bjtztxt.Text;

            string mystring = "server=192.168.168.100;database=RP_littleworld;uid=sa;pwd=cslg";
            SqlConnection scon = new SqlConnection(mystring);
            for (int i = 0; i < this.DropDownListusers.Items.Count; i++)
            {
                string receiveid = this.DropDownListusers.Items[i].Text;
                string mysql = "insert into noticeTb(adminID,title,contents,sentTime,receiveID) values(" + "1,'" + tilte + "' , '" + contect + "' , '" + System.DateTime.Now + "' , '" + receiveid + "' )";
                SqlCommand scom = scon.CreateCommand();
                scom.CommandText = mysql;
                scon.Open();
                scom.ExecuteNonQuery();
                scon.Close();
            }
        }
    }
}