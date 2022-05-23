using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmDiziTartisma.UserControl
{
    public partial class UserForgotPassword : System.Web.UI.UserControl
    {
        Siniflarim.Uyeler uye = new Siniflarim.Uyeler();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void forgot_password_Click(object sender, EventArgs e)
        {
            var kullanici = uye.GetByEmail(txt_email.Text);

            if (kullanici != null)
            {
                String guid = Guid.NewGuid().ToString();

                String ad = kullanici.uyeAd;
                String soyad = kullanici.uyeSoyad;
                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential("emredeneme09@gmail.com", "tshmjwryydlcmlcy");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                MailMessage mail = new MailMessage();
                mail.To.Add(kullanici.uyeEmail);
                mail.From = new MailAddress("emredeneme09@gmail.com", "Şifre Yenileme");
                mail.IsBodyHtml = true;
                mail.Subject = "Şifre Sıfırmalama";
                mail.Body += "Merhaba, " + ad + " " + soyad + "<br/>Şifreni sıfırlamak için linke tıkla <br/> https://localhost:44389/SifreSifirla?uid=" + guid;

                Session["resetpassword_email"] = kullanici.uyeEmail;

                try
                {
                    client.Send(mail);
                    Response.Write("<script>alert('Mesaj göderildi!');</script>");
                }
                catch (Exception)
                {
                    Response.Write("<script>alert('Mesaj gönderilemedi lütfen tekrar deneyiniz!');</script>");
                }
            }
            else
                Response.Write("<script>alert('Girdiğiniz email adresi bulunamadı!');</script>");
        }
    }
}