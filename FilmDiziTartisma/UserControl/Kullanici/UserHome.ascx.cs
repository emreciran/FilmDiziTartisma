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
    public partial class UserHome : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var filmData = ListeleFilm();
            Repeater1.DataSource = filmData;
            Repeater1.DataBind();

            var diziData = ListeleDizi();
            Repeater2.DataSource = diziData;
            Repeater2.DataBind();
        }

        private List<Veritabani.Filmler> ListeleFilm()
        {
            string apiUrl = "https://localhost:44369/api/Film/GetFilm";

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(apiUrl);

            var deger = (new JavaScriptSerializer()).Deserialize<List<Veritabani.Filmler>>(json);
            return deger;
        }

        private List<Veritabani.Diziler> ListeleDizi()
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