using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FilmDiziApi.Controllers
{
    public class OyuncuController : ApiController
    {
        Siniflarim.Oyuncular oyuncu = new Siniflarim.Oyuncular();

        [HttpGet]
        public List<Veritabani.Oyuncular> GetOyuncu()
        {
            var list = oyuncu.Listele();

            if (list.Count > 0)
                return list;

            else
                return null;
        }

        [HttpPost]
        public string PostOyuncu(string oyuncuAd, string oyuncuSoyad, string oyuncuFoto)
        {
            var sonuc = oyuncu.OyuncuEkle(oyuncuAd, oyuncuSoyad, oyuncuFoto);

            if (sonuc == "1")
                return "Oyuncu Eklendi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpPut]
        public string PutOyuncu(int id, string oyuncuAd, string oyuncuSoyad, string oyuncuFoto)
        {
            var sonuc = oyuncu.OyuncuGuncelle(id, oyuncuAd, oyuncuSoyad, oyuncuFoto);

            if (sonuc == "1")
                return "Oyuncu Güncellendi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpDelete]
        public string DeleteOyuncu(int id)
        {
            var sonuc = oyuncu.OyuncuSil(id);

            if (sonuc == "1")
                return "Oyuncu Silindi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }
    }
}