using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    public class Kategoriler
    {
        Veritabani.FilmDiziEntities db = new Veritabani.FilmDiziEntities();
        Veritabani.Kategoriler kategori = new Veritabani.Kategoriler();

        public string KategoriEkleme(string kategoriAd)
        {
            kategori.kategoriAd = kategoriAd;

            db.Kategoriler.Add(kategori);

            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public string KategoriGuncelle(int kategoriID, string kategoriAd)
        {
            var aranan = db.Kategoriler.Where(p => p.kategori_id == kategoriID).FirstOrDefault();

            aranan.kategoriAd = kategoriAd;

            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public string KategoriSilme(int kategoriID)
        {
            var aranan = db.Kategoriler.Where(p => p.kategori_id == kategoriID).FirstOrDefault();

            db.Kategoriler.Remove(aranan);

            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public List<Veritabani.Kategoriler> Listele()
        {
            var data = db.Kategoriler.ToList();

            return data;
        }

    }
}
