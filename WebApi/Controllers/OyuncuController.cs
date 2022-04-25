using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class OyuncuController : ApiController
    {
        Siniflarim.Oyuncular oyuncu = new Siniflarim.Oyuncular();

        [HttpGet]
        public List<Veritabani.Oyuncular> OyuncuBilgileri()
        {
            var list =  oyuncu.Listele();

            if (list.Count > 0)
                return list;

            else
                return null;
        }
    }
}