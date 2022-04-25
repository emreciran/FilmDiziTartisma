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

        public string YorumEkleme(string yorumAdsoyad, string yorumEmail, string yorumIcerik, string yorumTarih, bool yorumOnay)
        {
            yorum.yorumAdSoyad = yorumAdsoyad;
            yorum.yorumEmail = yorumEmail;
            yorum.yorumIcerik = yorumIcerik;
            yorum.yorumTarih = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");
            yorum.yorumOnay = false;

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

        public List<Veritabani.Yorumlar> Listele()
        {
            var data = db.Yorumlar.ToList();

            return data;
        }
    }
}
