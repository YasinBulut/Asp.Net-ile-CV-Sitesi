using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class Default : System.Web.UI.Page
    {
        DBCVEntityEntities db = new DBCVEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.Tbl_Hakkında.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.Tbl_Hakkında.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.Tbl_Hakkında.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = db.Tbl_Yetenekler.ToList();
            Repeater4.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_iletisim t = new Tbl_iletisim();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.KONU = TextBox3.Text;
            t.MESAJ = TextBox4.Text;
            db.Tbl_iletisim.Add(t);
            db.SaveChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
}