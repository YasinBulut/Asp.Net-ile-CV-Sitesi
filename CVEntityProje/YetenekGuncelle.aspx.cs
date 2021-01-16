using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        DBCVEntityEntities db = new DBCVEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack==false)
            {
                var yetenek = db.Tbl_Yetenekler.Find(id);
                TextBox1.Text = yetenek.YETENEK;
            }
     
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var yetenek = db.Tbl_Yetenekler.Find(id);
            yetenek.YETENEK = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}