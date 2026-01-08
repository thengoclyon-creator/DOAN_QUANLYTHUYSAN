namespace ĐồÁn_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Giong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Giong()
        {
            VuNuois = new HashSet<VuNuois>();
        }

        public int GiongID { get; set; }

        [StringLength(100)]
        public string TenGiong { get; set; }

        [StringLength(200)]
        public string NguonGoc { get; set; }

        public decimal? DonGiaNhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VuNuois> VuNuois { get; set; }
    }
}
