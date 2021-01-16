using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class İletişim : System.Web.UI.Page
    {
        DBCVEntityEntities db = new DBCVEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var mesajlar = db.Tbl_iletisim.ToList();
            Repeater1.DataSource = mesajlar;
            Repeater1.DataBind();
        }
    }
}