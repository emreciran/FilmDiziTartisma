using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    public class Diziler
    {
        Veritabani.FilmDiziEntities db = new Veritabani.FilmDiziEntities();
        Veritabani.Diziler dizi = new Veritabani.Diziler();

        public string DiziEkleme(string diziAd, int diziSezonSayisi, string IMDB, string diziAciklama, string diziYonetmen)
        {
            dizi.diziAd = diziAd;
            dizi.diziSezonsayisi = diziSezonSayisi;
            dizi.IMDB = IMDB;
            dizi.diziAciklama = diziAciklama;
            dizi.diziYonetmen = diziYonetmen;

            db.Diziler.Add(dizi);
            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public string DiziGuncelle(int diziID, string diziAd, int diziSezonSayisi, string IMDB, string diziAciklama, string diziYonetmen)
        {
            var aranan = db.Diziler.Where(p => p.dizi_id == diziID).ToList().FirstOrDefault();

            aranan.diziAd = diziAd;
            aranan.diziSezonsayisi = diziSezonSayisi;
            aranan.IMDB = IMDB;
            aranan.diziAciklama = diziAciklama;
            aranan.diziYonetmen = diziYonetmen;

            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public string DiziSilme(int diziID)
        {
            var aranan = db.Diziler.Where(p => p.dizi_id == diziID).ToList().FirstOrDefault();

            db.Diziler.Remove(aranan);

            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public List<Veritabani.Diziler> Listele()
        {
            var data = db.Diziler.ToList();

            return data;
        }
    }
}
