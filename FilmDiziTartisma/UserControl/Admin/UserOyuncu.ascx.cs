using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmDiziTartisma.UserControl.Admin
{
    public partial class UserOyuncu : System.Web.UI.UserControl
    {
        Veritabani.FilmDiziEntities db = new Veritabani.FilmDiziEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var model = Listele();
            GridView1.DataSource = model;
            GridView1.DataBind();
        }

        protected void btn_ekle_Click(object sender, EventArgs e)
        {
            var oyuncu_ad = txt_oyuncu_ad.Text;
            var oyuncu_soyad = txt_oyuncu_soyad.Text;
            var oyuncu_foto = txt_oyuncu_foto.Text;

            VeriEkle(oyuncu_ad, oyuncu_soyad, oyuncu_foto);      
            Response.Write("<script>alert('Oyuncu Eklendi');</script>");
        }

        protected void bn_guncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_oyuncu_guncelle_id.Text);
            var oyuncu_ad = txt_oyuncu_guncelle_ad.Text;
            var oyuncu_soyad = txt_oyuncu_guncelle_soyad.Text;
            var oyuncu_foto = txt_oyuncu_guncelle_foto.Text;

            VeriGuncelle(id, oyuncu_ad, oyuncu_soyad, oyuncu_foto);
            Response.Write("<script>alert('Oyuncu Güncellendi');</script>");
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).CommandArgument);

            VeriSilme(id);
            Response.Write("<script>alert('Oyuncu Silindi');</script>");
        }

        private List<Veritabani.Oyuncular> Listele()
        {
            string apiUrl = "https://localhost:44369/api/Oyuncu/GetOyuncu";

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(apiUrl);

            var deger = (new JavaScriptSerializer()).Deserialize<List<Veritabani.Oyuncular>>(json);
            return deger;
        }

        private string VeriEkle(string oyuncu_ad, string oyuncu_soyad, string oyuncu_foto)
        {
            string myParameters = "oyuncuAd=" + oyuncu_ad + "&" + "oyuncuSoyad=" + oyuncu_soyad + "&" + "oyuncuFoto=" + oyuncu_foto;
            string apiUrl = "https://localhost:44369/api/Oyuncu/PostOyuncu?" + myParameters;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "POST", myParameters);

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }

        private string VeriGuncelle(int id, string oyuncu_ad, string oyuncu_soyad, string oyuncu_foto)
        {
            string myParameters = "oyuncuAd=" + oyuncu_ad + "&" + "oyuncuSoyad=" + oyuncu_soyad + "&" + "oyuncuFoto=" + oyuncu_foto;
            string apiUrl = "https://localhost:44369/api/Oyuncu/PutOyuncu/" + id + "?" + myParameters;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "PUT", myParameters);

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }

        private string VeriSilme(int id)
        {
            string apiUrl = "https://localhost:44369/api/Oyuncu/DeleteOyuncu/" + id;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "DELETE", id.ToString());

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }
    }
}