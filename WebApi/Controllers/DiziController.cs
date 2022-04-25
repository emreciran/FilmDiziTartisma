using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class DiziController : ApiController
    {
        [HttpGet]
        public List<Veritabani.Diziler> DiziBilgileri()
        {
            var list = new Siniflarim.Diziler().Listele();

            if (list.Count > 0)
                return list;

            else
                return null;
        }
    }
}
