using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FilmDiziApi.Controllers
{
    public class FilmController : ApiController
    {
        Siniflarim.Filmler film = new Siniflarim.Filmler();

        [HttpGet]
        public List<Veritabani.Filmler> GetFilm()
        {
            var list = film.Listele();

            if (list.Count > 0)
                return list;

            else
                return null;
        }

        [HttpPost]
        public string PostFilm(string filmAd, string filmSuresi, string IMDB, string filmAciklama, string filmVideo, string filmYonetmen, string filmYonetmenFoto, string filmFoto, string filmOyuncu, string filmOyuncuFoto)
        {
            var sonuc = film.FilmEkleme(filmAd, filmSuresi, IMDB, filmAciklama, filmVideo, filmYonetmen, filmYonetmenFoto, filmFoto, filmOyuncu, filmOyuncuFoto);

            if (sonuc == "1")
                return "Film Eklendi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpDelete]
        public string DeleteFilm(int id)
        {
            var sonuc = film.FilmSilme(id);

            if (sonuc == "1")
                return "Film Silindi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpPut]
        public string PutFilm(int id, string filmAd, string filmSuresi, string IMDB, string filmAciklama, string filmVideo, string filmYonetmen, string filmYonetmenFoto, string filmFoto, string filmOyuncu, string filmOyuncuFoto)
        {
            var sonuc = film.FilmGuncelle(id, filmAd, filmSuresi, IMDB, filmAciklama, filmVideo, filmYonetmen, filmYonetmenFoto, filmFoto, filmOyuncu, filmOyuncuFoto);

            if (sonuc == "1")
                return "Film Güncellendi";

            else
                return "Hata oluştu tekrar deneyiniz";
        }

        [HttpGet]
        public List<Veritabani.Filmler> GetFilm(int id)
        {
            List<Veritabani.Filmler> sonuc = film.GetByFilmID(id);

            return sonuc;
        }
    }
}