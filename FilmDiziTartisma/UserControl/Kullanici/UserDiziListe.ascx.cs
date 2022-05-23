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
    public partial class UserDiziListe : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var model = Listele();
            Repeater1.DataSource = model;
            Repeater1.DataBind();
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
    }
}