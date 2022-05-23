using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FilmDiziApi.Controllers
{
    public class YonetmenController : ApiController
    {
        Siniflarim.Yonetmenler yonetmen = new Siniflarim.Yonetmenler();

        [HttpGet]
        public List<Veritabani.Yonetmenler> GetYonetmen()
        {
            var list = yonetmen.Listele();

            if (list.Count > 0)
                return list;

            else
                return null;
        }

        [HttpPost]
        public string PostYonetmen(string yonetmenAd, string yonetmenSoyad, string yonetmenFoto)
        {
            var sonuc = yonetmen.YonetmenEkle(yonetmenAd, yonetmenSoyad, yonetmenFoto);

            if (sonuc == "1")
                return "Yonetmen Eklendi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpPut]
        public string PutYonetmen(int id, string yonetmenAd, string yonetmenSoyad, string yonetmenFoto)
        {
            var sonuc = yonetmen.YonetmenGuncelle(id, yonetmenAd, yonetmenSoyad, yonetmenFoto);

            if (sonuc == "1")
                return "Yonetmen Güncellendi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpDelete]
        public string DeleteYonetmen(int id)
        {
            var sonuc = yonetmen.YonetmenSilme(id);

            if (sonuc == "1")
                return "Yonetmen Silindi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }
    }
}