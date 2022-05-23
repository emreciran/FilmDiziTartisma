using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmDiziTartisma.UserControl
{
    public partial class UserLogin : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btn_giris_yap_Click(object sender, EventArgs e)
        {
            var email = txt_email.Text;
            var password = txt_password.Text;
            var yetki = drp_yetki.SelectedItem.Text;

            var kullanici = new Siniflarim.Uyeler().GetByKullanici(email, password, yetki);
            
            if (kullanici != null)
            {
                Session["Kullanici"] = kullanici;

                if (kullanici.uyeYetki == "Kullanıcı")
                {
                    Response.Redirect("/Kullanici/AnaSayfa");
                }
                else if (kullanici.uyeYetki == "Yazar")
                {
                    Response.Redirect("/Yazar/Film");
                }

                if(kullanici.uyeYetki == "Admin")
                {
                    Response.Redirect("/Admin/KullaniciListe");
                }
            }
            else
            {
                Response.Write("<script>alert('Hatalı kullanıcı adı veya şifre');</script>");
            }
        }
    }
}