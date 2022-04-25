using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class YonetmenController : ApiController
    {
        Siniflarim.Yonetmenler yonetmen = new Siniflarim.Yonetmenler();

        [HttpGet]
        public List<Veritabani.Yonetmenler> YonetmenBilgileri()
        {
            var list = yonetmen.Listele();

            if (list.Count > 0)
                return list;

            else
                return null;
        }
    }
}