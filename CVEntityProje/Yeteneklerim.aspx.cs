using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class Hakkımda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVEntityEntities db = new DBCVEntityEntities();
            Repeater1.DataSource = db.Tbl_Yetenekler.ToList();
            Repeater1.DataBind();
        }
    }
}