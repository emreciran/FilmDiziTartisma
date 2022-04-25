using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class KategoriController : ApiController
    {
        [HttpGet]
        public List<Veritabani.Kategoriler> KategoriBilgileri()
        {
            var list = new Siniflarim.Kategoriler().Listele();

            if (list.Count > 0)
                return list;

            else
                return null;
        }

    }
}
