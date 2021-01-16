using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVEntityEntities DB = new DBCVEntityEntities();
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var yetenek = DB.Tbl_Yetenekler.Find(x);
            DB.Tbl_Yetenekler.Remove(yetenek);
            DB.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}