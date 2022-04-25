using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Siniflarim
{
    public class YazarYetkiKontrol : System.Web.UI.Page
    {
        protected override void OnLoad(EventArgs e)
        {
            var yetki = (Veritabani.Uyeler)System.Web.HttpContext.Current.Session["Kullanici"];

            if (yetki.uyeYetki != "Yazar")
                Response.Redirect("/Giris");


            base.OnLoad(e);
        }
    }

    public class AdminYetkiKontrol : System.Web.UI.Page
    {
        protected override void OnLoad(EventArgs e)
        {
            var yetki = (Veritabani.Uyeler)System.Web.HttpContext.Current.Session["Kullanici"];

            if (yetki.uyeYetki != "Admin")
                Response.Redirect("/Giris");


            base.OnLoad(e);
        }
    }
}
