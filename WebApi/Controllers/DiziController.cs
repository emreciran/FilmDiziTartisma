using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FilmDiziApi.Controllers
{
    public class DiziController : ApiController
    {
        Siniflarim.Diziler dizi = new Siniflarim.Diziler();

        [HttpGet]
        public List<Veritabani.Diziler> GetDizi()
        {
            var list = dizi.Listele();

            if (list.Count > 0)
                return list;

            else
                return null;
        }

        [HttpPost]
        public string PostDizi(string diziAd, int diziSezonSayisi, string IMDB, string diziAciklama, string diziVideo, string diziYonetmen, string diziYonetmenFoto, string diziFoto, string diziOyuncu, string diziOyuncuFoto)
        {
            var sonuc = dizi.DiziEkleme(diziAd, diziSezonSayisi, IMDB, diziAciklama, diziVideo, diziYonetmen, diziYonetmenFoto, diziFoto, diziOyuncu, diziOyuncuFoto);

            if (sonuc == "1")
                return "Dizi Eklendi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpDelete]
        public string DeleteDizi(int id)
        {
            var sonuc = dizi.DiziSilme(id);

            if (sonuc == "1")
                return "Dizi Silindi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpPut]
        public string PutDizi(int id, string diziAd, int diziSezonSayisi, string IMDB, string diziAciklama, string diziVideo, string diziYonetmen, string diziYonetmenFoto, string diziFoto, string diziOyuncu, string diziOyuncuFoto)
        {
            var sonuc = dizi.DiziGuncelle(id, diziAd, diziSezonSayisi, IMDB, diziAciklama, diziVideo, diziYonetmen, diziYonetmenFoto, diziFoto, diziOyuncu, diziOyuncuFoto);

            if (sonuc == "1")
                return "Dizi Güncellendi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpGet]
        public List<Veritabani.Diziler> GetDizi(int id)
        {
            List<Veritabani.Diziler> sonuc = dizi.GetByDiziID(id);
            return sonuc;
        }
    }
}