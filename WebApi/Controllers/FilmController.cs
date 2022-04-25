using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class FilmController : ApiController
    {
        [HttpGet]
        public List<Veritabani.Filmler> FilmBilgileri()
        {
            var list = new Siniflarim.Filmler().Listele();

            if (list.Count > 0)
                return list;

            else
                return null;
        }
    }
}
