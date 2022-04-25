using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmDiziTartisma.UserControl
{
    public partial class UserResetPassword : System.Web.UI.UserControl
    {
        Siniflarim.Uyeler uye = new Siniflarim.Uyeler();
        protected void Page_Load(object sender, EventArgs e)
        {
            var uid = Request.QueryString["uid"];

            if (uid == null)
                Response.Redirect("Giris");
        }

        protected void reset_password_Click(object sender, EventArgs e)
        {
            if (txt_new_password.Text != "" && txt_confirm_password.Text != "" && txt_new_password.Text == txt_confirm_password.Text)
            {
                var email = System.Web.HttpContext.Current.Session["resetpassword_email"];
                uye.SifreGuncelle(email.ToString(), txt_new_password.Text);
                Response.Write("<script>alert('Şifreniz güncellendi!');</script>");      
            }
            else
                Response.Write("<script>alert('Girdiğiniz değerleri kontrol ediniz!');</script>");


            Response.Redirect("Giris");

        }
    }
}