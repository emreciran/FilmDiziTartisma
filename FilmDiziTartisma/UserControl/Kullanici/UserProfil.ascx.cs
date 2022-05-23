using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmDiziTartisma.UserControl.Kullanıcı
{
    public partial class UserProfil : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var kullanici = (Veritabani.Uyeler)System.Web.HttpContext.Current.Session["Kullanici"];
            
            var model = Listele(kullanici.uye_id);
            DataList1.DataSource = model;
            DataList1.DataBind();
        }

        private List<Veritabani.Uyeler> Listele(int id)
        {
            string apiUrl = "https://localhost:44369/api/Uye/GetUye/" + id;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(apiUrl);

            var deger = (new JavaScriptSerializer()).Deserialize<List<Veritabani.Uyeler>>(json);
            return deger;
        }
    }
}