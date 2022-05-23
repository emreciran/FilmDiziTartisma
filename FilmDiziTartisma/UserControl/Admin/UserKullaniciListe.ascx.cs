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
    public partial class UserKullanici : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var model = Listele();
            GridView1.DataSource = model;
            GridView1.DataBind();
        }

        protected void btn_ekle_Click(object sender, EventArgs e)
        {
            var kullanici_ad = txt_kullanici_ad.Text;
            var kullanici_soyad = txt_kullanici_soyad.Text;
            var kullanici_email = txt_email.Text;
            var kullanici_password = txt_kullanici_password.Text;
            var kullanici_yetki = drp_yetki.SelectedItem.Text;

            VeriEkle(kullanici_ad, kullanici_soyad, kullanici_email, kullanici_password, kullanici_yetki);
            Response.Write("<script>alert('Kullanıcı Eklendi');</script>");       
        }

        protected void btn_modal_yetki_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_kullanici_id.Text);
            var yetki = modal_yetki.SelectedItem.Text;

            VeriGuncelle(id, yetki);
            Response.Write("<script>alert('Yetki Güncellendi');</script>");
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).CommandArgument);
            VeriSilme(id);
            Response.Write("<script>alert('Kullanıcı Silindi');</script>");
        }

        private List<Veritabani.Uyeler> Listele()
        {
            string apiUrl = "https://localhost:44369/api/Uye/GetUye";

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(apiUrl);

            var deger = (new JavaScriptSerializer()).Deserialize<List<Veritabani.Uyeler>>(json);
            return deger;
        }

        private string VeriEkle(string kullanici_ad, string kullanici_soyad, string kullanici_email, string kullanici_password, string kullanici_yetki)
        {
            string myParameters = "uyeAd=" + kullanici_ad + "&" + "uyeSoyad=" + kullanici_soyad + "&" + "uyeEmail=" + kullanici_email + "&" + "uyePassword=" + kullanici_password + "&" + "uyeYetki=" + kullanici_yetki;
            string apiUrl = "https://localhost:44369/api/Uye/PostUye?" + myParameters;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "POST", myParameters);

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }

        private string VeriSilme(int id)
        {
            string apiUrl = "https://localhost:44369/api/Uye/DeleteUye/" + id;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "DELETE", id.ToString());

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }

        private string VeriGuncelle(int id, string kullanici_yetki)
        {
            string myParameters = "uyeYetki=" + kullanici_yetki;
            string apiUrl = "https://localhost:44369/api/Uye/PutUye/" + id + "?" + myParameters;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "PUT", myParameters);

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }
    }
}