using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace FilmDiziTartisma
{
    public class Global : System.Web.HttpApplication
    {

        void Yonlendir(RouteCollection route)
        {
            //LOGIN SIGNUP FORGOT PASSWORD RESET PASSWORD
            route.MapPageRoute("Giris", "Giris", "~/Login.aspx");
            route.MapPageRoute("Kayit", "Kayit", "~/Signup.aspx");
            route.MapPageRoute("Sifre", "SifremiUnuttum", "~/ForgotPassword.aspx");
            route.MapPageRoute("SifreSifirla", "SifreSifirla", "~/ResetPassword.aspx");

            //YAZAR YETKİ
            route.MapPageRoute("Film", "Yazar/Film", "~/Yazar/Film.aspx");
            route.MapPageRoute("Film param", "Yazar/Film/{FilmNo}", "~/Yazar/Film.aspx");
            route.MapPageRoute("Dizi", "Yazar/Dizi", "~/Yazar/Dizi.aspx");
            route.MapPageRoute("Dizi param", "Yazar/Dizi/{DiziNo}", "~/Yazar/Dizi.aspx");

            //ADMIN YETKİ
            route.MapPageRoute("KullaniciListe", "Admin/KullaniciListe", "~/Admin/KullaniciListe.aspx");
            route.MapPageRoute("Kategori", "Admin/Kategori", "~/Admin/Kategori.aspx");
            route.MapPageRoute("Yonetmen", "Admin/Yonetmen", "~/Admin/Yonetmen.aspx");
            route.MapPageRoute("Oyuncu", "Admin/Oyuncu", "~/Admin/Oyuncu.aspx");
            route.MapPageRoute("Yorum", "Admin/Yorum", "~/Admin/Yorum.aspx");

            //KULLANICI YETKİ
            route.MapPageRoute("FilmListe", "Kullanici/FilmListe", "~/Kullanici/FilmListe.aspx");
            route.MapPageRoute("DiziListe", "Kullanici/DiziListe", "~/Kullanici/DiziListe.aspx");
            route.MapPageRoute("KategoriListe", "Kullanici/KategoriListe", "~/Kullanici/KategoriListe.aspx");
            route.MapPageRoute("Profil", "Kullanici/Profil", "~/Kullanici/Profil.aspx");
            route.MapPageRoute("AnaSayfa", "Kullanici/AnaSayfa", "~/Kullanici/Home.aspx");
            route.MapPageRoute("FilmDetay", "Kullanici/FilmDetay", "~/Kullanici/FilmDetay.aspx");
            route.MapPageRoute("DiziDetay", "Kullanici/DiziDetay", "~/Kullanici/DiziDetay.aspx");
            
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            Yonlendir(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}