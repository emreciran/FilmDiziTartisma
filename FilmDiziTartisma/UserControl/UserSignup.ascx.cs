using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmDiziTartisma.UserControl
{
    public partial class UserSignup : System.Web.UI.UserControl
    {
        Siniflarim.Uyeler veriekle = new Siniflarim.Uyeler();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var name_ = name.Text;
            var surname_ = surname.Text;
            var email_ = email.Text;
            var password_ = password.Text;
            var yetki = drp_yetki.SelectedItem.Text;

            if (yetki == null)
                yetki = "Kullanıcı";

            var sonuc = veriekle.VeriEkleme(name_, surname_, email_, password_, yetki);

            if (sonuc == "1")
            {
                Response.Redirect("Giris");
            }

            else
                Response.Write("<script>alert('Lütfen tekrar deneyiniz');</script>");
        }
    }
}