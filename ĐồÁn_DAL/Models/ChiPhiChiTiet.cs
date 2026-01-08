namespace ĐồÁn_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class ChiPhiChiTiet
    {
        public int ID { get; set; }

        public int? VuNuoiID { get; set; }

        public int? VatTuID { get; set; }

        public double? SoLuongSuDung { get; set; }

        public decimal? DonGiaTaiThoiDiem { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySuDung { get; set; }

        public virtual VatTu VatTu { get; set; }

        public virtual VuNuois VuNuois { get; set; }
        public double LayTongChiPhi(int idVu)
        {
            using (var db = new Ketnoi())
            {
                try
                {
                    // Ép kiểu cả 2 cột về (double) trước khi nhân để tránh lỗi toán tử *
                    var tongVatTu = db.ChiPhiChiTiets
                                      .Where(c => c.VuNuoiID == idVu)
                                      .Select(c => (double?)((double)c.SoLuongSuDung * (double)c.DonGiaTaiThoiDiem))
                                      .Sum() ?? 0;

                    return tongVatTu;
                }
                catch
                {
                    return 0;
                }
            }
        }

        // --- NEW METHOD FOR REPORT ---
        public object LayDanhSachChiPhi(int idVu)
        {
            using (var db = new Ketnoi())
            {
                var data = db.ChiPhiChiTiets
                             .Where(c => c.VuNuoiID == idVu)
                             .Join(db.VatTus,
                                   cp => cp.VatTuID,
                                   vt => vt.VatTuID,
                                   (cp, vt) => new
                                   {
                                       Ngay = cp.NgaySuDung,
                                       TenVatTu = vt.TenVatTu,
                                       SoLuong = cp.SoLuongSuDung,
                                       DonGia = cp.DonGiaTaiThoiDiem,
                                       ThanhTien = (double)cp.SoLuongSuDung * (double)cp.DonGiaTaiThoiDiem
                                   })
                             .OrderBy(x => x.Ngay)
                             .ToList();
                return data;
            }
        }
    }
}
