namespace ĐồÁn_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class TangTruong
    {
        public int ID { get; set; }

        public int? VuNuoiID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDo { get; set; }

        public double? TrongLuongBinhQuan { get; set; }

        public virtual VuNuois VuNuois { get; set; }
        public List<TangTruong> LayDanhSachTheoVu(int idVu)
        {
            using (var db = new Ketnoi())
            {
                // Phải có .Where(t => t.VuNuoiID == idVu)
                return db.TangTruongs.Where(t => t.VuNuoiID == idVu).OrderBy(t => t.NgayDo).ToList();
            }
        }
    }

}
