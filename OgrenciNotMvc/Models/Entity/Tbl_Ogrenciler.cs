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
    
    public partial class Tbl_Ogrenciler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Ogrenciler()
        {
            this.Tbl_Notlar = new HashSet<Tbl_Notlar>();
        }
    
        public int OgrenciID { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
        public string OgrenciFotograf { get; set; }
        public string OgrenciCinsiyet { get; set; }
        public Nullable<int> OgrenciKulüp { get; set; }
    
        public virtual Tbl_Kulüpler Tbl_Kulüpler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Notlar> Tbl_Notlar { get; set; }
    }
}
