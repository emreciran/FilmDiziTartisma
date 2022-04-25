using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class UyeController : ApiController
    {
        [HttpGet]
        public List<Veritabani.Uyeler> UyeBilgileri()
        {
            var list = new Siniflarim.Uyeler().Listele();

            if (list.Count > 0)
                return list;
            else
                return null;
        }
    }
}
