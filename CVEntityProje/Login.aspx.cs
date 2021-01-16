using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DBCVEntityEntities db = new DBCVEntityEntities();
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.Tbl_Admin where x.KULLANICIAD == TextBox1.Text && x.SIFRE == TextBox2.Text select x;
            if (sorgu.Any())
            {
                Response.Redirect("İletişim.aspx");
            }
            else
            {
                Response.Write("HATALI GİRİŞ!!");
            }
        }

      
    }
}