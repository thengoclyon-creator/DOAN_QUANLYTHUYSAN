namespace ĐồÁn_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VuNuois
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VuNuois()
        {
            ChiPhiChiTiets = new HashSet<ChiPhiChiTiet>();
            TangTruongs = new HashSet<TangTruong>();
        }

        [Key]
        public int VuNuoiID { get; set; }

        public int? AoID { get; set; }

        public int? GiongID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTha { get; set; }

        public int? SoLuongTha { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThuHoachDuKien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThuHoachThucTe { get; set; }

        public double? TongSankg { get; set; }

        public int? SizeHienTai { get; set; }

        public bool? TrangThai { get; set; }

        public virtual Ao Ao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiPhiChiTiet> ChiPhiChiTiets { get; set; }

        public virtual Giong Giong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TangTruong> TangTruongs { get; set; }
    }
}
