using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class YorumController : ApiController
    {
        [HttpGet]
        public List<Veritabani.Yorumlar> YorumBilgileri()
        {
            var list = new Siniflarim.Yorumlar().Listele();

            if (list.Count > 0)
                return list;

            else
                return null;
        }
    }
}
