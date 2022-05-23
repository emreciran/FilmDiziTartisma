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
    public partial class UserYorum : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var model = Listele();
            GridView1.DataSource = model;
            GridView1.DataBind();
        }

        protected void btn_onay_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).CommandArgument);

            YorumOnayGuncelle(id);
            Listele();
            Response.Write("<script>alert('Yorum Onay Güncellendi');</script>");
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).CommandArgument);

            YorumSil(id);
            Listele();
            Response.Write("<script>alert('Yorum Silindi');</script>");
        }

        private List<Veritabani.Yorumlar> Listele()
        {
            string apiUrl = "https://localhost:44369/api/Yorum/GetYorum";

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(apiUrl);

            var deger = (new JavaScriptSerializer()).Deserialize<List<Veritabani.Yorumlar>>(json);
            return deger;
        }

        public string YorumOnayGuncelle(int id)
        {
            string apiUrl = "https://localhost:44369/api/Yorum/PutYorumOnay/" + id;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "PUT", id.ToString());

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }

        public string YorumSil(int id)
        {
            string apiUrl = "https://localhost:44369/api/Yorum/DeleteYorum/" + id;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiUrl, "DELETE", id.ToString());

            var deger = (new JavaScriptSerializer()).Serialize(json);
            return deger;
        }
    }
}