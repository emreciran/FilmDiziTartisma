using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmDiziTartisma.UserControl.Admin
{
    public partial class UserYonetmen : System.Web.UI.UserControl
    {
        Veritabani.FilmDiziEntities db = new Veritabani.FilmDiziEntities();
        Siniflarim.Yonetmenler yonetmen = new Siniflarim.Yonetmenler();

        protected void Page_Load(object sender, EventArgs e)
        {
            var model = Listele();
            GridView1.DataSource = model;
            GridView1.DataBind();
        }

        protected void btn_ekle_Click(object sender, EventArgs e)
        {
            var yonetmen_ad = txt_yonetmen_ad.Text;
            var yonetmen_soyad = txt_yonetmen_soyad.Text;
            var yonetmen_foto = txt_yonetmen_foto.Text;

            VeriEkle(yonetmen_ad, yonetmen_soyad, yonetmen_foto);
            Response.Write("<script>alert('Yönetmen Eklendi');</script>");
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).CommandArgument);
            VeriSilme(id);
            Response.Write("<script>alert('Yönetmen Silindi');</script>");
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_yonetmen_guncelle_id.Text);
            var yonetmen_ad = txt_yonetmen_guncelle_ad.Text;
            var yonetmen_soyad = txt_yonetmen_guncelle_soyad.Text;
            var yonetmen_foto = txt_yonetmen_guncelle_foto.Text;

            VeriGuncelle(id, yonetmen_ad, yonetmen_soyad, yonetmen_foto);
            Response.Write("<script>alert('Yönetmen Güncellendi');</script>");
        }

        private List<Veritabani.Yonetmenler> Listele()
        {
            string apiUrl = "https://localhost:44369/api/Yonetmen/GetYonetmen";

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(apiUrl);

            var deger = (new JavaScriptSerializer()).Deserialize<List<Veritabani.Yonetmenler>>(json);
            return deger;
        }

        private string VeriEkle(string yonetmen_ad, string yonetmen_soyad, string yonetmen_foto)
        {
            string myParameters = "yonetmenAd=" + yonetmen_ad + "&" + "yonetmenSoyad=" + yonetmen_soyad + "&" + "yonetmenFoto=" + yonetmen_foto;
            string apiUrl = "https://localhost:44369/api/Yonetmen/PostYonetmen?" + myParameters;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "POST", myParameters);

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }

        private string VeriSilme(int id)
        {
            string apiUrl = "https://localhost:44369/api/Yonetmen/DeleteYonetmen/" + id;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "DELETE", id.ToString());

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }

        private string VeriGuncelle(int id, string yonetmen_ad, string yonetmen_soyad, string yonetmen_foto)
        {
            string myParameters = "yonetmenAd=" + yonetmen_ad + "&" + "yonetmenSoyad=" + yonetmen_soyad + "&" + "yonetmenFoto=" + yonetmen_foto;
            string apiUrl = "https://localhost:44369/api/Yonetmen/PutYonetmen/" + id + "?" + myParameters;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "PUT", myParameters);

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }

    }
}