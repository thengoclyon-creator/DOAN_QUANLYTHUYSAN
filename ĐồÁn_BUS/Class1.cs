using ĐồÁn_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ĐồÁn_DAL.Models.ChiPhiChiTiet;
using static ĐồÁn_DAL.Models.Ketnoi;

namespace ĐồÁn_BUS
{
    public class Class1
    {
    }
    public class AoBUS
    {
        AoDAL dal = new AoDAL();

        public List<Ao> LayDanhSach()
        {
            return dal.GetListAo();
        }

        public string Them(string ten, double dt, string vitri, string loai)
        {
            if (string.IsNullOrEmpty(ten)) return "Tên không được để trống";
            Ao ao = new Ao { TenAo = ten, DienTich = dt, ViTri = vitri, LoaiAo = loai, TrangThai = "Trống" };
            return dal.Them(ao) ? "Thêm thành công" : "Thêm thất bại";
        }

        public string Sua(int id, string ten, double dt, string vitri, string loai)
        {
            Ao ao = new Ao { AoID = id, TenAo = ten, DienTich = dt, ViTri = vitri, LoaiAo = loai };
            return dal.Sua(ao) ? "Sửa thành công" : "Sửa thất bại";
        }

        public string Xoa(int id) => dal.Xoa(id) ? "Xóa thành công" : "Xóa thất bại";
        public class TangTruongBUS
        {
            // Khai báo đúng Model để gọi hàm xử lý dữ liệu
            TangTruong model = new TangTruong();

            public List<TangTruong> LayDS(int idInput)
            {
                // 1. Thử lấy dữ liệu giả định đầu vào là VuNuoiID
                var data = model.LayDanhSachTheoVu(idInput);

                // 2. Nếu không có dữ liệu, có thể đầu vào là AoID -> tìm VuNuoi mới nhất của Ao đó
                if (data == null || data.Count == 0)
                {
                    using (var db = new Ketnoi())
                    {
                        var vu = db.VuNuois.Where(v => v.AoID == idInput).OrderByDescending(v => v.NgayTha).FirstOrDefault();
                        if (vu != null)
                        {
                            data = model.LayDanhSachTheoVu(vu.VuNuoiID);
                        }
                    }
                }

                // 3. Nếu vẫn không có dữ liệu (Ao 3, Ao 4 cũ chưa nhập), tạo dữ liệu ảo để vẽ biểu đồ cho đẹp
                if (data == null || data.Count == 0)
                {
                    data = new List<TangTruong>();
                    DateTime startDate = DateTime.Now.AddDays(-30);
                    double weight = 5.0; // Bắt đầu 5g
                    Random r = new Random();

                    for (int i = 0; i < 15; i++)
                    {
                        TangTruong tt = new TangTruong();
                        tt.NgayDo = startDate.AddDays(i * 2);
                        tt.TrongLuongBinhQuan = weight;
                        data.Add(tt);

                        // Tăng trưởng ngẫu nhiên
                        weight += r.NextDouble() * 2.0 + 1.0; 
                    }
                }

                return data;
            }
        }
        public class TongKetBUS
        {
            // Vì hàm LayTongChiPhi bạn viết trong model ChiPhiChiTiet nên ta gọi từ model đó
            ChiPhiChiTiet modelCP = new ChiPhiChiTiet();

            public double GetChiPhi(int idVu)
            {
                // Gọi hàm tính tổng từ DAL/Model
                return modelCP.LayTongChiPhi(idVu);
            }

            public object GetChiPhiChiTiet(int idAo)
            {
                using (var db = new Ketnoi())
                {
                    // Lấy vụ nuôi mới nhất của Ao này
                    var vu = db.VuNuois
                               .Where(v => v.AoID == idAo)
                               .OrderByDescending(v => v.NgayTha)
                               .FirstOrDefault();

                    // Nếu không có dữ liệu thực tế, tạo dữ liệu ảo để demo (theo yêu cầu người dùng)
                    if (vu == null)
                    {
                        var mockData = new List<object>();
                        mockData.Add(new { Ngay = DateTime.Now.AddDays(-10), TenVatTu = "Thức ăn demo (Ao " + idAo + ")", SoLuong = 50.0, DonGia = 400000m, ThanhTien = 20000000.0 });
                        mockData.Add(new { Ngay = DateTime.Now.AddDays(-5), TenVatTu = "Thuốc tím demo", SoLuong = 5.0, DonGia = 150000m, ThanhTien = 750000.0 });
                        return mockData;
                    }

                    var listData = modelCP.LayDanhSachChiPhi(vu.VuNuoiID);
                    
                    // Nếu list rỗng cũng trả về mock data
                    // Sử dụng IList để check Count an toàn cho dữ liệu Anonymous Type
                    System.Collections.IList checkList = listData as System.Collections.IList;
                    if (checkList != null && checkList.Count == 0)
                    {
                         var mockData = new List<object>();
                         mockData.Add(new { Ngay = DateTime.Now.AddDays(-2), TenVatTu = "Điện năng tiêu thụ (Demo)", SoLuong = 100.0, DonGia = 3500m, ThanhTien = 350000.0 });
                         return mockData;
                    }

                    return listData;
                }
            }

            public double TinhToanLoiNhuan(double sanLuong, double giaBan, double chiPhi)
            {
                return (sanLuong * giaBan) - chiPhi;
            }

            public double LaySanLuongTuSQL(int idVu)
            {
                using (var db = new Ketnoi())
                {
                    var vu = db.VuNuois.FirstOrDefault(v => v.VuNuoiID == idVu);
                    return (double)(vu?.TongSankg ?? 0);
                }
            }

            // [NEW] Method to get full Season Details for the Summary UI
            public ThongTinVuNuoiDTO GetThongTinVuNuoi(int idAo)
            {
                using (var db = new Ketnoi())
                {
                    var vu = db.VuNuois
                               .Where(v => v.AoID == idAo)
                               .OrderByDescending(v => v.NgayTha)
                               .FirstOrDefault();

                    // FIX: Nếu không có dữ liệu (Ao 3, 4), trả về dữ liệu ảo để demo
                    if (vu == null) 
                    {
                        return new ThongTinVuNuoiDTO
                        {
                            NgayTha = DateTime.Now.AddMonths(-4),
                            NgayThu = DateTime.Now.AddMonths(-1),
                            SoLuongTha = 120000,
                            TenGiong = "Tôm Thẻ Chân Trắng (Demo)",
                            TongSanLuong = 3500
                        };
                    }

                    // Get Seed Name safely
                    string tenGiong = "N/A";
                    if (vu.GiongID != null)
                    {
                        var giong = db.Giongs.FirstOrDefault(g => g.GiongID == vu.GiongID);
                        if (giong != null) tenGiong = giong.TenGiong;
                    }

                    // FIX: Nếu Ao 1 chưa thu hoạch (NgayThu null), dự kiến ngày thu = ngày thả + 3 tháng
                    DateTime? ngayThu = vu.NgayThuHoachThucTe;
                    if (ngayThu == null && vu.NgayTha != null)
                    {
                        ngayThu = vu.NgayTha.Value.AddMonths(3);
                    }

                    return new ThongTinVuNuoiDTO
                    {
                        NgayTha = vu.NgayTha,
                        NgayThu = ngayThu,
                        SoLuongTha = vu.SoLuongTha,
                        TenGiong = tenGiong,
                        TongSanLuong = vu.TongSankg ?? 0
                    };
                }
            }
        }
    }

    public class ThongTinVuNuoiDTO
    {
        public DateTime? NgayTha { get; set; }
        public DateTime? NgayThu { get; set; }
        public int? SoLuongTha { get; set; }
        public string TenGiong { get; set; }
        public double? TongSanLuong { get; set; }
    }
}
