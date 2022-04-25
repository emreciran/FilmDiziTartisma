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

        public string FilmEkleme(string filmAd, string filmSuresi, string IMDB, string filmAciklama, string filmYonetmen)
        {
            film.filmAd = filmAd;
            film.filmSuresi = filmSuresi;
            film.IMDB = IMDB;
            film.filmAciklama = filmAciklama;
            film.filmYonetmen = filmYonetmen;

            db.Filmler.Add(film);
            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public string FilmGuncelle(int filmID, string filmAd, string filmSuresi, string IMDB, string filmAciklama, string filmYonetmen)
        {
            var aranan = db.Filmler.Where(p => p.film_id == filmID).ToList().FirstOrDefault();

            aranan.filmAd = filmAd;
            aranan.filmSuresi = filmSuresi;
            aranan.IMDB = IMDB;
            aranan.filmAciklama = filmAciklama;
            aranan.filmYonetmen = filmYonetmen;

            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public string FilmSilme(int filmID)
        {
            var aranan = db.Filmler.Where(p => p.film_id == filmID).ToList().FirstOrDefault();

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
    }
}
