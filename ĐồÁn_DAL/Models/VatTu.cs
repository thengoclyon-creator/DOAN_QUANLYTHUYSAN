namespace ĐồÁn_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VatTu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VatTu()
        {
            ChiPhiChiTiets = new HashSet<ChiPhiChiTiet>();
        }

        public int VatTuID { get; set; }

        [StringLength(100)]
        public string TenVatTu { get; set; }

        [StringLength(50)]
        public string LoaiVatTu { get; set; }

        [StringLength(20)]
        public string DonViTinh { get; set; }

        public double? SoLuongTon { get; set; }

        public decimal? GiaVon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiPhiChiTiet> ChiPhiChiTiets { get; set; }
    }
}
