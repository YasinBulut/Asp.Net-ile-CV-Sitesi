using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class İstatistik : System.Web.UI.Page
    {
        DBCVEntityEntities db = new DBCVEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.Tbl_Yetenekler.Count().ToString();
            Label2.Text = db.Tbl_iletisim.Count().ToString();
            Label3.Text = db.Tbl_Yetenekler.Average(x => x.DERECE).ToString();
            Label4.Text = db.Tbl_Yetenekler.Max(X=>X.DERECE).ToString();
        }
    }
}