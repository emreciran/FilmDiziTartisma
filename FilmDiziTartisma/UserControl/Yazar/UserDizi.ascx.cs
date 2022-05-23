using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmDiziTartisma.UserControl.Yazar
{
    public partial class UserDizi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var model = Listele();
            GridView1.DataSource = model;
            GridView1.DataBind();
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_dizi_guncelle_id.Text);
            var diziAd = txt_dizi_guncelle_ad.Text;
            int sezonSayisi = Convert.ToInt32(txt_dizi_guncelle_sezon.Text);
            var IMDB = txt_dizi_guncelle_imdb.Text;
            var aciklama = txt_dizi_guncelle_aciklama.Text;
            var video = txt_dizi_guncelle_video.Text;
            var yonetmen = txt_dizi_guncelle_yonetmen.Text;
            var yonetmenFoto = txt_dizi_guncelle_yonetmen_foto.Text;
            var foto = txt_dizi_guncelle_fotograf.Text;
            var oyuncu = txt_dizi_guncelle_oyuncu.Text;
            var oyuncuFoto = txt_dizi_guncelle_oyuncu_foto.Text;

            VeriGuncelle(id, diziAd, sezonSayisi, IMDB, aciklama, video, yonetmen, yonetmenFoto, foto, oyuncu, oyuncuFoto);
            Response.Write("<script>alert('Dizi Güncellendi');</script>");
        }

        protected void btn_ekle_Click(object sender, EventArgs e)
        {
            var diziAd = txt_dizi_ad.Text;
            int sezonSayisi = Convert.ToInt32(txt_dizi_sezon.Text);
            var IMDB = txt_dizi_imdb.Text;
            var aciklama = txt_dizi_aciklama.Text;
            var video = txt_dizi_video.Text;
            var yonetmen = txt_dizi_yonetmen.Text;
            var yonetmenFoto = txt_dizi_yonetmen_foto.Text;
            var foto = txt_dizi_fotograf.Text;
            var oyuncu = txt_dizi_oyuncu.Text;
            var oyuncuFoto = txt_dizi_guncelle_oyuncu_foto.Text;

            VeriEkle(diziAd, sezonSayisi, IMDB, aciklama, video, yonetmen, yonetmenFoto, foto, oyuncu, oyuncuFoto);
            Response.Write("<script>alert('Dizi Eklendi');</script>");
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).CommandArgument);

            VeriSilme(id);
            Response.Write("<script>alert('Dizi Silindi');</script>");
        }

        private List<Veritabani.Diziler> Listele()
        {
            string apiUrl = "https://localhost:44369/api/Dizi/GetDizi";

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(apiUrl);

            var deger = (new JavaScriptSerializer()).Deserialize<List<Veritabani.Diziler>>(json);
            return deger;
        }

        private string VeriEkle(string diziAd, int sezonSayisi, string IMDB, string aciklama, string video, string yonetmen, string yonetmenFoto, string foto, string oyuncu, string oyuncuFoto)
        {
            string myParameters = "diziAd=" + diziAd + "&" + "diziSezonsayisi=" + sezonSayisi + "&" + "IMDB=" + IMDB + "&" + "diziAciklama=" + aciklama + "&" + "diziVideo=" + video + "&" + "diziYonetmen=" + yonetmen + "&" + "diziYonetmenFoto=" + yonetmenFoto + "&" + "diziFoto=" + foto + "&" + "diziOyuncu=" + oyuncu + "&" + "diziOyuncuFoto=" + oyuncuFoto;
            string apiUrl = "https://localhost:44369/api/Dizi/PostDizi?" + myParameters;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "POST", myParameters);

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }

        private string VeriSilme(int id)
        {
            string apiUrl = "https://localhost:44369/api/Dizi/DeleteDizi/" + id;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "DELETE", id.ToString());

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }

        private string VeriGuncelle(int id, string diziAd, int sezonSayisi, string IMDB, string aciklama, string video, string yonetmen, string yonetmenFoto, string foto, string oyuncu, string oyuncuFoto)
        {
            string myParameters = "diziAd=" + diziAd + "&" + "diziSezonsayisi=" + sezonSayisi + "&" + "IMDB=" + IMDB + "&" + "diziAciklama=" + aciklama + "&" + "diziVideo=" + video + "&" + "diziYonetmen=" + yonetmen + "&" + "diziYonetmenFoto=" + yonetmenFoto + "&" + "diziFoto=" + foto + "&" + "diziOyuncu=" + oyuncu + "&" + "diziOyuncuFoto=" + oyuncuFoto;
            string apiUrl = "https://localhost:44369/api/Dizi/PutDizi/" + id + "?" + myParameters;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "PUT", myParameters);

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }
    }
}