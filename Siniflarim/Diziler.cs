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

        public string DiziEkleme(string diziAd, int diziSezonSayisi, string IMDB, string diziAciklama, string diziVideo, string diziYonetmen, string diziYonetmenFoto, string diziFoto, string diziOyuncu, string diziOyuncuFoto)
        {
            dizi.diziAd = diziAd;
            dizi.diziSezonsayisi = diziSezonSayisi;
            dizi.IMDB = IMDB;
            dizi.diziAciklama = diziAciklama;
            dizi.diziVideo = diziVideo;
            dizi.diziYonetmen = diziYonetmen;
            dizi.diziYonetmenFoto = diziYonetmenFoto;
            dizi.diziFoto = diziFoto;
            dizi.diziOyuncu = diziOyuncu;
            dizi.diziOyuncuFoto = diziOyuncuFoto;

            db.Diziler.Add(dizi);
            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public string DiziGuncelle(int id, string diziAd, int diziSezonSayisi, string IMDB, string diziAciklama, string diziVideo, string diziYonetmen, string diziYonetmenFoto, string diziFoto, string diziOyuncu, string diziOyuncuFoto)
        {
            var aranan = db.Diziler.Where(p => p.dizi_id == id).FirstOrDefault();

            aranan.diziAd = diziAd;
            aranan.diziSezonsayisi = diziSezonSayisi;
            aranan.IMDB = IMDB;
            aranan.diziAciklama = diziAciklama;
            aranan.diziVideo = diziVideo;
            aranan.diziYonetmen = diziYonetmen;
            aranan.diziYonetmenFoto = diziYonetmenFoto;
            aranan.diziFoto = diziFoto;
            aranan.diziOyuncu = diziOyuncu;
            aranan.diziOyuncuFoto = diziOyuncuFoto;

            int sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public string DiziSilme(int id)
        {
            var aranan = db.Diziler.Where(p => p.dizi_id == id).FirstOrDefault();

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

        public List<Veritabani.Diziler> GetByDiziID(int id)
        {
            List<Veritabani.Diziler> sonuc = db.Diziler.Where(p => p.dizi_id == id).ToList();

            if (sonuc != null)
                return sonuc;

            else
                return null;
        }
    }
}
