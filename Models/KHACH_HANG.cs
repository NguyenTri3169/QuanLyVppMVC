//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyVppMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHACH_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACH_HANG()
        {
            this.PHIEU_MUON = new HashSet<PHIEU_MUON>();
        }
    
        public string Ma_Khach_hang { get; set; }
        public string Password { get; set; }
        public string Ten_Khach_hang { get; set; }
        public Nullable<System.DateTime> Ngay_sinh { get; set; }
        public string Dia_Chi { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_MUON> PHIEU_MUON { get; set; }
    }
}
