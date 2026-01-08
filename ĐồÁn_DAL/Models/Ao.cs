namespace ĐồÁn_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ao()
        {
            VuNuois = new HashSet<VuNuois>();
        }

        public int AoID { get; set; }

        [StringLength(100)]
        public string TenAo { get; set; }

        public double? DienTich { get; set; }

        [StringLength(200)]
        public string ViTri { get; set; }

        [StringLength(50)]
        public string LoaiAo { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VuNuois> VuNuois { get; set; }
    }
}
