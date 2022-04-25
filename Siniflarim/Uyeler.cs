using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veritabani;


namespace Siniflarim
{
    public class Uyeler
    {
        Veritabani.FilmDiziEntities db = new Veritabani.FilmDiziEntities();
        Veritabani.Uyeler uye = new Veritabani.Uyeler();

        public string VeriEkleme(string ad, string soyad, string email, string password, string yetki)
        {
            uye.uyeAd = ad;
            uye.uyeSoyad = soyad;
            uye.uyeEmail = email;
            uye.uyePassword = password;
            uye.uyeYetki = yetki;

            db.Uyeler.Add(uye);

            int sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";

            else
                return "0";
        }

        public string VeriGuncelle(int uyeID, string ad, string soyad, string email, string password)
        {
            var aranan = db.Uyeler.Where(p => p.uye_id == uyeID).ToList().FirstOrDefault();

            aranan.uyeAd = ad;
            aranan.uyeSoyad = soyad;
            aranan.uyeEmail = email;
            aranan.uyePassword = password;

            db.SaveChanges();

            return "1";

        }

        public string VeriSilme(int uyeID)
        {
            var aranan = db.Uyeler.Where(p => p.uye_id == uyeID).FirstOrDefault();

            db.Uyeler.Remove(aranan);
            int sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";

            else
                return "0";

        }

        public Veritabani.Uyeler GetByKullanici(string email, string sifre, string yetki)
        {
            var sonuc = db.Uyeler.Where(p => p.uyeEmail == email && p.uyePassword == sifre && p.uyeYetki == yetki);

            if (email == "emreefeciran2000@hotmail.com")
            {
                if (yetki == "Kullanıcı" || yetki == "Yazar")
                    yetki = "Admin";
            }

            if (sonuc != null)
            {
                return sonuc.FirstOrDefault();
            }
            else
                return null;
        }

        public List<Veritabani.Uyeler> Listele()
        {
            var data = db.Uyeler.ToList();

            return data;
        }

        public Veritabani.Uyeler GetByEmail(string email)
        {
            var sonuc = db.Uyeler.Where(p => p.uyeEmail == email).FirstOrDefault();

            if (sonuc != null)
                return sonuc;

            else
                return null;
        }

        public string SifreGuncelle(string email, string password)
        {
            var aranan = db.Uyeler.Where(p => p.uyeEmail == email).FirstOrDefault();

            aranan.uyePassword = password;
            int sonuc = db.SaveChanges();

            if (sonuc == 1)
                return "1";

            else
                return "0";
        }
    }
}
