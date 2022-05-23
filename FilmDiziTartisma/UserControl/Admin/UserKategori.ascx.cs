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
    public partial class UserKategori : System.Web.UI.UserControl
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
            var kategori_ad = txt_kategori_ad.Text;
            VeriEkle(kategori_ad);
            Response.Write("<script>alert('Kategori Eklendi');</script>");  
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            int kategori_id = Convert.ToInt32((sender as Button).CommandArgument);
            VeriSilme(kategori_id);
            Response.Write("<script>alert('Kategori Silindi');</script>");
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_kategori_id_guncelle.Text);
            var yeni_kategori_ad = txt_kategori_ad_guncelle.Text;

            VeriGuncelle(id, yeni_kategori_ad);
            Response.Write("<script>alert('Kategori Güncellendi');</script>");
        }


        private List<Veritabani.Kategoriler> Listele()
        {
            string apiUrl = "https://localhost:44369/api/Kategori/GetKategori";
            
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(apiUrl);

            var deger = (new JavaScriptSerializer()).Deserialize<List<Veritabani.Kategoriler>>(json);
            return deger;
        }

        private string VeriEkle(string kategori_ad)
        {
            string myParameters = "kategoriAd=" + kategori_ad;
            string apiUrl = "https://localhost:44369/api/Kategori/PostKategori?" + myParameters;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "POST", myParameters);

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }

        private string VeriSilme(int id)
        {
            string apiUrl = "https://localhost:44369/api/Kategori/DeleteKategori/" + id;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "DELETE", id.ToString());

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }

        private string VeriGuncelle(int id, string yeni_kategori_ad)
        {
            string myParameters = "kategoriAd=" + yeni_kategori_ad;
            string apiUrl = "https://localhost:44369/api/Kategori/PutKategori/" + id + "?" + myParameters;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "PUT", myParameters);

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }
    }
}