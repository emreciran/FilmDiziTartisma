using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    public class Filmler
    {
        Veritabani.FilmDiziEntities db = new Veritabani.FilmDiziEntities();
        Veritabani.Filmler film = new Veritabani.Filmler();

        public string FilmEkleme(string filmAd, string filmSuresi, string IMDB, string filmAciklama, string filmVideo, string filmYonetmen, string filmYonetmenFoto, string filmFoto, string filmOyuncu, string filmOyuncuFoto)
        {
            film.filmAd = filmAd;
            film.filmSuresi = filmSuresi;
            film.IMDB = IMDB;
            film.filmAciklama = filmAciklama;
            film.filmVideo = filmVideo;
            film.filmYonetmen = filmYonetmen;
            film.filmYonetmenFoto = filmYonetmenFoto;
            film.filmFoto = filmFoto;
            film.filmOyuncu = filmOyuncu;
            film.filmOyuncuFoto = filmOyuncuFoto;

            db.Filmler.Add(film);
            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public string FilmGuncelle(int id, string filmAd, string filmSuresi, string IMDB, string filmAciklama, string filmVideo, string filmYonetmen, string filmYonetmenFoto, string filmFoto, string filmOyuncu, string filmOyuncuFoto)
        {
            var aranan = db.Filmler.Where(p => p.film_id == id).FirstOrDefault();

            aranan.filmAd = filmAd;
            aranan.filmSuresi = filmSuresi;
            aranan.IMDB = IMDB;
            aranan.filmAciklama = filmAciklama;
            aranan.filmVideo = filmVideo;
            aranan.filmYonetmen = filmYonetmen;
            aranan.filmYonetmenFoto = filmYonetmenFoto;
            aranan.filmFoto = filmFoto;
            aranan.filmOyuncu = filmOyuncu;
            aranan.filmOyuncuFoto = filmOyuncuFoto;

            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public string FilmSilme(int id)
        {
            var aranan = db.Filmler.Where(p => p.film_id == id).FirstOrDefault();

            db.Filmler.Remove(aranan);

            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public List<Veritabani.Filmler> Listele()
        {
            var data = db.Filmler.ToList();

            return data;
        }

        public List<Veritabani.Filmler> GetByFilmID(int id)
        {
            List<Veritabani.Filmler> sonuc = db.Filmler.Where(p => p.film_id == id).ToList();

            if (sonuc != null)
                return sonuc;

            else
                return null;
        }
    }
}
