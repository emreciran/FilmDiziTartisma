using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    public class Yorumlar
    {
        Veritabani.FilmDiziEntities db = new Veritabani.FilmDiziEntities();
        Veritabani.Yorumlar yorum = new Veritabani.Yorumlar();

        public string YorumEklemeFilm(string yorumAdsoyad, string yorumEmail, string yorumIcerik, string yorumTarih, bool yorumOnay, int yorumFilmID)
        {
            yorum.yorumAdSoyad = yorumAdsoyad;
            yorum.yorumEmail = yorumEmail;
            yorum.yorumIcerik = yorumIcerik;
            yorum.yorumTarih = yorumTarih;
            yorum.yorumOnay = yorumOnay;
            yorum.yorumFilmID = yorumFilmID;

            db.Yorumlar.Add(yorum);
            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public string YorumEklemeDizi(string yorumAdsoyad, string yorumEmail, string yorumIcerik, string yorumTarih, bool yorumOnay, int yorumDiziID)
        {
            yorum.yorumAdSoyad = yorumAdsoyad;
            yorum.yorumEmail = yorumEmail;
            yorum.yorumIcerik = yorumIcerik;
            yorum.yorumTarih = yorumTarih;
            yorum.yorumOnay = yorumOnay;
            yorum.yorumDiziID = yorumDiziID;

            db.Yorumlar.Add(yorum);
            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public string YorumSilme(int yorumID)
        {
            var aranan = db.Yorumlar.Where(p => p.yorum_id == yorumID).FirstOrDefault();

            db.Yorumlar.Remove(aranan);
            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public string YorumGuncelle(int yorumID, string yorumAdsoyad, string yorumEmail, string yorumIcerik, string yorumTarih, bool yorumOnay)
        {
            var aranan = db.Yorumlar.Where(p => p.yorum_id == yorumID).FirstOrDefault();

            aranan.yorumAdSoyad = yorumAdsoyad;
            aranan.yorumEmail = yorumEmail;
            aranan.yorumIcerik = yorumIcerik;
            aranan.yorumTarih = yorumTarih;
            aranan.yorumOnay = yorumOnay;

            var sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";
            else
                return "0";
        }

        public List<Veritabani.Yorumlar> Listele()
        {
            var data = db.Yorumlar.ToList();

            return data;
        }

        public List<Veritabani.Yorumlar> DiziOnayliYorumListele(int yorumDiziID)
        {
            var data = db.Yorumlar.Where(p => p.yorumOnay == true && p.yorumDiziID == yorumDiziID).ToList();

            return data;
        }

        public List<Veritabani.Yorumlar> FilmOnayliYorumListele(int yorumFilmID)
        {
            var data = db.Yorumlar.Where(p => p.yorumOnay == true && p.yorumFilmID == yorumFilmID).ToList();

            return data;
        }

        public string YorumOnayGuncelle(int yorumID)
        {
            var aranan = db.Yorumlar.Where(p => p.yorum_id == yorumID).FirstOrDefault();

            if (aranan.yorumOnay == false)
                aranan.yorumOnay = true;

            else if (aranan.yorumOnay == true)
                aranan.yorumOnay = false;

            var sonuc = db.SaveChanges();
            if (sonuc == 1)
                return "1";

            else
                return "0";
        }
    }
}
