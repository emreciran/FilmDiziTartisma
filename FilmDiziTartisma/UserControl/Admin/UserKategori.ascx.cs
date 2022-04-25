using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmDiziTartisma.UserControl.Admin
{
    public partial class UserKategori : System.Web.UI.UserControl
    {
        Veritabani.FilmDiziEntities db = new Veritabani.FilmDiziEntities();
        Siniflarim.Kategoriler kategori = new Siniflarim.Kategoriler();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                FillData();
        }

        protected void btn_kategori_ekle_Click(object sender, EventArgs e)
        {
            var kategori_ad = txt_kategori_ad.Text;

            kategori.KategoriEkleme(kategori_ad);
        }

        private void FillData()
        {
            this.GridView1.DataSource = db.Kategoriler.Select(k => new {
                kategoriID = k.kategori_id,
                kategoriAd = k.kategoriAd
            }).ToList();
            this.GridView1.DataBind();
        }

    }
}