using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    public class Menu
    {
        Veritabani.FilmDiziEntities db = new Veritabani.FilmDiziEntities();

        public List<Veritabani.Menu> GetByYetki(string YetkiAdi)
        {
            var sonuc = db.Menu.Where(p => p.menuYetki == YetkiAdi).ToList();

            return sonuc;
        }
    }
}
