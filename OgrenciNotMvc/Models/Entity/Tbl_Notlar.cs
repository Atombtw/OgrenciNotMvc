//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OgrenciNotMvc.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Notlar
    {
        public int NotID { get; set; }
        public Nullable<int> DersID { get; set; }
        public Nullable<int> OgrenciID { get; set; }
        public Nullable<byte> Sinav1 { get; set; }
        public Nullable<byte> Sinav2 { get; set; }
        public Nullable<byte> Sinav3 { get; set; }
        public Nullable<byte> Proje { get; set; }
        public Nullable<decimal> Ortalama { get; set; }
        public Nullable<bool> Durum { get; set; }
    
        public virtual Tbl_Dersler Tbl_Dersler { get; set; }
        public virtual Tbl_Ogrenciler Tbl_Ogrenciler { get; set; }
    }
}
