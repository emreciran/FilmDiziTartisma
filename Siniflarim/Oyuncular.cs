using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    public class Oyuncular
    {
        Veritabani.FilmDiziEntities db = new Veritabani.FilmDiziEntities();
        Veritabani.Oyuncular oyuncu = new Veritabani.Oyuncular();

        public string OyuncuEkle(string oyuncuAd, string oyuncuSoyad, string oyuncuFoto)
        {
            oyuncu.oyuncuAd = oyuncuAd;
            oyuncu.oyuncuSoyad = oyuncuSoyad;
            oyuncu.oyuncuFoto = oyuncuFoto;

            db.Oyuncular.Add(oyuncu);
            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";

            else
                return "0";
        }

        public string OyuncuGuncelle(int oyuncu_id, string oyuncuAd, string oyuncuSoyad, string oyuncuFoto)
        {
            var aranan = db.Oyuncular.Where(p => p.oyuncu_id == oyuncu_id).FirstOrDefault();

            aranan.oyuncuAd = oyuncuAd;
            aranan.oyuncuSoyad = oyuncuSoyad;
            aranan.oyuncuFoto = oyuncuFoto;

            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";

            else
                return "0";
        }

        public string OyuncuSil(int oyuncu_id)
        {
            var aranan = db.Oyuncular.Where(p => p.oyuncu_id == oyuncu_id).FirstOrDefault();

            db.Oyuncular.Remove(aranan);

            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";

            else
                return "0";
        }

        public List<Veritabani.Oyuncular> Listele()
        {
            var list = db.Oyuncular.ToList();

            if (list.Count > 0)
                return list;

            else
                return null;
        }
    }
}
