using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmDiziTartisma
{
    public partial class YazarLayout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var kullanici = (Veritabani.Uyeler)System.Web.HttpContext.Current.Session["Kullanici"];
            user_email.Text = kullanici.uyeEmail;
        }

        protected void btn_cikis_yap_Click(object sender, EventArgs e)
        {
            System.Web.HttpContext.Current.Session["Kullanici"] = null;

            Response.Redirect("../Giris");
        }
    }
}