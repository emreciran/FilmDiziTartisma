using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FilmDiziApi.Controllers
{
    public class KategoriController : ApiController
    {
        Siniflarim.Kategoriler kategori = new Siniflarim.Kategoriler();

        [HttpGet]
        public List<Veritabani.Kategoriler> GetKategori()
        {
            var list = kategori.Listele();

            if (list.Count > 0)
                return list;

            else
                return null;
        }

        [HttpPost]
        public string PostKategori(string kategoriAd)
        {
            var sonuc = kategori.KategoriEkleme(kategoriAd);

            if (sonuc == "1")
                return "Kategori Eklendi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpDelete]
        public string DeleteKategori(int id)
        {
            var sonuc = kategori.KategoriSilme(id);

            if (sonuc == "1")
                return "Kategori Silindi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpPut]
        public string PutKategori(int id, string kategoriAd)
        {
            var sonuc = kategori.KategoriGuncelle(id, kategoriAd);

            if (sonuc == "1")
                return "Kategori Güncellendi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }
    }
}