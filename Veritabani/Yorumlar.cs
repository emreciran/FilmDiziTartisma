//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Veritabani
{
    using System;
    using System.Collections.Generic;
    
    public partial class Yorumlar
    {
        public int yorum_id { get; set; }
        public string yorumAdSoyad { get; set; }
        public string yorumEmail { get; set; }
        public string yorumIcerik { get; set; }
        public string yorumTarih { get; set; }
        public Nullable<bool> yorumOnay { get; set; }
        public Nullable<int> yorumFilmID { get; set; }
        public Nullable<int> yorumDiziID { get; set; }
    }
}
