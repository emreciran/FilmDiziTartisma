using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmDiziTartisma.UserControl
{
    public partial class UserMenu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var yetki = (Veritabani.Uyeler)System.Web.HttpContext.Current.Session["Kullanici"];
            var menu = new Siniflarim.Menu().GetByYetki(yetki.uyeYetki).ToList();

            if(menu != null)
            {
                string menu_item = "";

                for (int i = 0; i < menu.Count; i++)
                {
                    menu_item += "<li \" class=\"nav-item d-none d-sm-inline-block\">";
                    menu_item += "<a href=\"" + menu[i].menuAdres + "\" class=\"menu_link nav-link\">" + menu[i].menuAdi+"</a>";
                    menu_item += "</li>";
                }
                lt_menu.Text += menu_item;
            }
        }
    }
}