using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmDiziTartisma.UserControl.Kullanici
{
    public partial class UserFilmDetay : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filmID = Request.QueryString["filmID"];

            var model = Listele(Convert.ToInt32(filmID));
            Repeater2.DataSource = model;
            Repeater2.DataBind();

            var yorumlar = YorumListeleFilm(Convert.ToInt32(filmID));
            Repeater1.DataSource = yorumlar;
            Repeater1.DataBind();
        }

        protected void btn_gonder_Click(object sender, EventArgs e)
        {
            string ad = txt_ad.Text;
            string email = txt_email.Text;
            string message = txt_message.Text;
            DateTime now = DateTime.Now;
            string tarih = now.ToString("dd-MM-yyyy h:mm");
            bool onay = false;
            int filmID = Convert.ToInt32(Request.QueryString["filmID"]);

            YorumEkle(ad, email, message, tarih, onay, filmID);

            txt_ad.Text = "";
            txt_email.Text = "";
            txt_message.Text = "";

            txt_bilgi.Text = "Yorumunuz başarıyla gönderildi! Yorumunuz onaylanınca listelencektir.";
        }

        private List<Veritabani.Filmler> Listele(int id)
        {
            string apiUrl = "https://localhost:44369/api/Film/GetFilm/" + id;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(apiUrl);

            var deger = (new JavaScriptSerializer()).Deserialize<List<Veritabani.Filmler>>(json);
            return deger;
        }

        private string YorumEkle(string yorumAdsoyad, string yorumEmail, string yorumIcerik, string yorumTarih, bool yorumOnay, int filmID)
        {
            string myParameters = "yorumAdsoyad=" + yorumAdsoyad + "&" + "yorumEmail=" + yorumEmail + "&" + "yorumIcerik=" + yorumIcerik + "&" + "yorumTarih=" + yorumTarih + "&" + "yorumOnay=" + yorumOnay + "&" + "yorumFilmID=" + filmID;
            string apiUrl = "https://localhost:44369/api/Yorum/PostYorumFilm?" + myParameters;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "POST", myParameters);

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }

        private List<Veritabani.Yorumlar> YorumListeleFilm(int id)
        {
            string apiUrl = "https://localhost:44369/api/Yorum/GetYorumByOnayFilm/" + id;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(apiUrl);

            var deger = (new JavaScriptSerializer()).Deserialize<List<Veritabani.Yorumlar>>(json);
            return deger;
        }
    }
}