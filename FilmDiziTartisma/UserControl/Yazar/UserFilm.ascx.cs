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
    public partial class UserFilm : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var model = Listele();
            GridView1.DataSource = model;
            GridView1.DataBind();
        }

        protected void btn_ekle_Click(object sender, EventArgs e)
        {
            var filmAd = txt_film_ad.Text;
            var filmSuresi = txt_film_suresi.Text;
            var IMDB = txt_film_imdb.Text;
            var aciklama = txt_film_aciklama.Text;
            var video = txt_film_video.Text;
            var yonetmen = txt_film_yonetmen.Text;
            var yonetmenFoto = txt_film_yonetmen_foto.Text;
            var foto = txt_film_fotograf.Text;
            var oyuncu = txt_film_oyuncu.Text;
            var oyuncuFoto = txt_film_oyuncu_foto.Text;

            VeriEkle(filmAd, filmSuresi, IMDB, aciklama, video, yonetmen, yonetmenFoto, foto, oyuncu, oyuncuFoto);
            Response.Write("<script>alert('Film Eklendi');</script>");
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_film_guncelle_id.Text);
            var filmAd = txt_film_guncelle_ad.Text;
            var filmSuresi = txt_film_guncelle_suresi.Text;
            var IMDB = txt_film_guncelle_imdb.Text;
            var aciklama = txt_film_guncelle_aciklama.Text;
            var video = txt_film_guncelle_video.Text;
            var yonetmen = txt_film_guncelle_yonetmen.Text;
            var yonetmenFoto = txt_film_guncelle_yonetmen_foto.Text;
            var foto = txt_film_guncelle_fotograf.Text;
            var oyuncu = txt_film_guncelle_oyuncu.Text;
            var oyuncuFoto = txt_film_guncelle_oyuncu_foto.Text;

            VeriGuncelle(id, filmAd, filmSuresi, IMDB, aciklama, video, yonetmen, yonetmenFoto, foto, oyuncu, oyuncuFoto);
            Response.Write("<script>alert('Film Güncelledi');</script>");
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).CommandArgument);

            VeriSilme(id);
            Response.Write("<script>alert('Film Silindi');</script>");
        }

        private List<Veritabani.Filmler> Listele()
        {
            string apiUrl = "https://localhost:44369/api/Film/GetFilm";

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(apiUrl);

            var deger = (new JavaScriptSerializer()).Deserialize<List<Veritabani.Filmler>>(json);
            return deger;
        }

        private string VeriEkle(string filmAd, string filmSuresi, string IMDB, string aciklama, string video, string yonetmen, string yonetmenFoto, string foto, string oyuncu, string oyuncuFoto)
        {
            string myParameters = "filmAd=" + filmAd + "&" + "filmSuresi=" + filmSuresi + "&" + "IMDB=" + IMDB + "&" + "filmAciklama=" + aciklama + "&" + "filmVideo=" + video + "&" + "filmYonetmen=" + yonetmen + "&" + "filmYonetmenFoto=" + yonetmenFoto + "&" + "filmFoto=" + foto + "&" + "filmOyuncu=" + oyuncu + "&" + "filmOyuncuFoto=" + oyuncuFoto;
            string apiUrl = "https://localhost:44369/api/Film/PostFilm?" + myParameters;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "POST", myParameters);

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }

        private string VeriSilme(int id)
        {
            string apiUrl = "https://localhost:44369/api/Film/DeleteFilm/" + id;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "DELETE", id.ToString());

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }

        private string VeriGuncelle(int id, string filmAd, string filmSuresi, string IMDB, string aciklama, string video, string yonetmen, string yonetmenFoto, string foto, string oyuncu, string oyuncuFoto)
        {
            string myParameters = "filmAd=" + filmAd + "&" + "filmSuresi=" + filmSuresi + "&" + "IMDB=" + IMDB + "&" + "filmAciklama=" + aciklama + "&" + "filmVideo=" + video + "&" + "filmYonetmen=" + yonetmen + "&" + "filmYonetmenFoto=" + yonetmenFoto + "&" + "filmFoto=" + foto + "&" + "filmOyuncu=" + oyuncu + "&" + "filmOyuncuFoto=" + oyuncuFoto;
            string apiUrl = "https://localhost:44369/api/Film/PutFilm/" + id + "?" + myParameters;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "PUT", myParameters);

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }
    }
}