using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FilmDiziApi.Controllers
{
    public class UyeController : ApiController
    {
        Siniflarim.Uyeler uye = new Siniflarim.Uyeler();

        [HttpGet]
        public List<Veritabani.Uyeler> GetUye()
        {
            var list = uye.Listele();

            if (list.Count > 0)
                return list;
            else
                return null;
        }

        [HttpPost]
        public string PostUye(string ad, string soyad, string email, string password, string yetki)
        {
            var sonuc = uye.VeriEkleme(ad, soyad, email, password, yetki);

            if (sonuc == "1")
                return "Üye Eklendi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpPut]
        public string PutUye(int id, string yetki)
        {
            var sonuc = uye.YetkiGuncelle(id, yetki);

            if (sonuc == "1")
                return "Yetki Güncellendi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpDelete]
        public string DeleteUye(int id)
        {
            var sonuc = uye.VeriSilme(id);

            if (sonuc == "1")
                return "Üye Silindi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpGet]
        public List<Veritabani.Uyeler> GetUye(int id)
        {
            List<Veritabani.Uyeler> sonuc = uye.GetByKullaniciID(id);
            return sonuc;
        }
    }
}