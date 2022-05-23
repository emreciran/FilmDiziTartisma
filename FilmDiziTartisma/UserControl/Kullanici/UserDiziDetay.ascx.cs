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
    public partial class UserDiziDetay : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string diziID = Request.QueryString["diziID"];

            var model = Listele(Convert.ToInt32(diziID));
            Repeater1.DataSource = model;
            Repeater1.DataBind();

            var yorumlar = YorumListeleDizi(Convert.ToInt32(diziID));
            Repeater2.DataSource = yorumlar;
            Repeater2.DataBind();
        }

        private List<Veritabani.Diziler> Listele(int id)
        {
            string apiUrl = "https://localhost:44369/api/Dizi/GetDizi/" + id;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(apiUrl);

            var deger = (new JavaScriptSerializer()).Deserialize<List<Veritabani.Diziler>>(json);
            return deger;
        }

        protected void btn_gonder_Click(object sender, EventArgs e)
        {
            string ad = txt_ad.Text;
            string email = txt_email.Text;
            string message = txt_message.Text;
            DateTime now = DateTime.Now;
            string tarih = now.ToString("dd-MM-yyyy h:mm");
            bool onay = false;
            int diziID = Convert.ToInt32(Request.QueryString["diziID"]);

            YorumEkle(ad, email, message, tarih, onay, diziID);

            txt_ad.Text = "";
            txt_email.Text = "";
            txt_message.Text = "";

            txt_bilgi.Text = "Yorumunuz başarıyla gönderildi! Yorumunuz onaylanınca listelencektir.";
        }

        private string YorumEkle(string yorumAdsoyad, string yorumEmail, string yorumIcerik, string yorumTarih, bool yorumOnay, int diziID)
        {
            string myParameters = "yorumAdsoyad=" + yorumAdsoyad + "&" + "yorumEmail=" + yorumEmail + "&" + "yorumIcerik=" + yorumIcerik + "&" + "yorumTarih=" + yorumTarih + "&" + "yorumOnay=" + yorumOnay + "&" + "yorumDiziID=" + diziID;
            string apiUrl = "https://localhost:44369/api/Yorum/PostYorumDizi?" + myParameters;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "POST", myParameters);

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }

        private List<Veritabani.Yorumlar> YorumListeleDizi(int id)
        {
            string apiUrl = "https://localhost:44369/api/Yorum/GetYorumByOnayDizi/" + id;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(apiUrl);

            var deger = (new JavaScriptSerializer()).Deserialize<List<Veritabani.Yorumlar>>(json);
            return deger;
        }
    }
}