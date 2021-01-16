using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        DBCVEntityEntities db = new DBCVEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var mesaj = db.Tbl_iletisim.Find(id);
            txtadsoyad.Text = mesaj.ADSOYAD;
            txtmail.Text = mesaj.MAIL;
            txtbaslık.Text = mesaj.KONU;
            txtmesaj.Text = mesaj.MESAJ;
        }
    }
}