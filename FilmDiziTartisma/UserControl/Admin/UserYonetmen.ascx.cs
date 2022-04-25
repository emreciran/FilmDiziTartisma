using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
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

        }

        protected void btn_kategori_ekle_Click(object sender, EventArgs e)
        {

        }

    }
}