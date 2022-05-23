using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    public class Yonetmenler
    {
        Veritabani.FilmDiziEntities db = new Veritabani.FilmDiziEntities();
        Veritabani.Yonetmenler yonetmen = new Veritabani.Yonetmenler();

        public string YonetmenEkle(string yonetmenAd, string yonetmenSoyad, string yonetmenFoto)
        {
            yonetmen.yonetmenAd = yonetmenAd;
            yonetmen.yonetmenSoyad = yonetmenSoyad;
            yonetmen.yonetmenFoto = yonetmenFoto;

            db.Yonetmenler.Add(yonetmen);

            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public string YonetmenGuncelle(int yonetmenID, string yonetmenAd, string yonetmenSoyad, string yonetmenFoto)
        {
            var aranan = db.Yonetmenler.Where(p => p.yonetmen_id == yonetmenID).FirstOrDefault();

            aranan.yonetmenAd = yonetmenAd;
            aranan.yonetmenSoyad = yonetmenSoyad;
            aranan.yonetmenFoto = yonetmenFoto;

            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public string YonetmenSilme(int yonetmenID)
        {
            var aranan = db.Yonetmenler.Where(p => p.yonetmen_id == yonetmenID).FirstOrDefault();

            db.Yonetmenler.Remove(aranan);

            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public List<Veritabani.Yonetmenler> Listele()
        {
            var list = db.Yonetmenler.ToList();

            if (list.Count > 0)
                return list;

            else
                return null;
        }
    }
}
