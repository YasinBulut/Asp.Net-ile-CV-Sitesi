﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class YeniYetenek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DBCVEntityEntities db = new DBCVEntityEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Yetenekler t = new Tbl_Yetenekler();
            t.YETENEK = TextBox1.Text;
            db.Tbl_Yetenekler.Add(t);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}