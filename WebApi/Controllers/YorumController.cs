using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FilmDiziApi.Controllers
{
    public class YorumController : ApiController
    {
        Siniflarim.Yorumlar yorum = new Siniflarim.Yorumlar();

        [HttpGet]
        public List<Veritabani.Yorumlar> GetYorum()
        {
            var list = yorum.Listele();

            if (list.Count > 0)
                return list;

            else
                return null;
        }

        [HttpGet]
        public List<Veritabani.Yorumlar> GetYorumByOnayDizi(int id)
        {
            var list = yorum.DiziOnayliYorumListele(id);

            if (list.Count > 0)
                return list;

            else
                return null;
        }

        [HttpGet]
        public List<Veritabani.Yorumlar> GetYorumByOnayFilm(int id)
        {
            var list = yorum.FilmOnayliYorumListele(id);

            if (list.Count > 0)
                return list;

            else
                return null;
        }

        [HttpPost]
        public string PostYorumFilm(string yorumAdsoyad, string yorumEmail, string yorumIcerik, string yorumTarih, bool yorumOnay, int yorumFilmID)
        {
            var sonuc = yorum.YorumEklemeFilm(yorumAdsoyad, yorumEmail, yorumIcerik, yorumTarih, yorumOnay, yorumFilmID);

            if (sonuc == "1")
                return "Yorum Eklendi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpPost]
        public string PostYorumDizi(string yorumAdsoyad, string yorumEmail, string yorumIcerik, string yorumTarih, bool yorumOnay, int yorumDiziID)
        {
            var sonuc = yorum.YorumEklemeDizi(yorumAdsoyad, yorumEmail, yorumIcerik, yorumTarih, yorumOnay, yorumDiziID);

            if (sonuc == "1")
                return "Yorum Eklendi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpDelete]
        public string DeleteYorum(int id)
        {
            var sonuc = yorum.YorumSilme(id);

            if (sonuc == "1")
                return "Yorum Silindi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpPut]
        public string PutYorum(int id, string yorumAdsoyad, string yorumEmail, string yorumIcerik, string yorumTarih, bool yorumOnay)
        {
            var sonuc = yorum.YorumGuncelle(id, yorumAdsoyad, yorumEmail, yorumIcerik, yorumTarih, yorumOnay);

            if (sonuc == "1")
                return "Yorum Güncellendi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpPut]
        public string PutYorumOnay(int id)
        {
            var sonuc = yorum.YorumOnayGuncelle(id);

            if (sonuc == "1")
                return "Onay Güncellendi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }
    }
}