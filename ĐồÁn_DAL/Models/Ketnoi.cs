using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ĐồÁn_DAL.Models
{
    public partial class Ketnoi : DbContext
    {
        public Ketnoi()
            : base("name=Ketnoi")
        {
        }

        public virtual DbSet<Ao> Aos { get; set; }
        public virtual DbSet<ChiPhiChiTiet> ChiPhiChiTiets { get; set; }
        public virtual DbSet<Giong> Giongs { get; set; }
        public virtual DbSet<TangTruong> TangTruongs { get; set; }
        public virtual DbSet<VatTu> VatTus { get; set; }
        public virtual DbSet<VuNuois> VuNuois { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public class AoDAL
        {
            Ketnoi db = new Ketnoi();

            // Lấy danh sách ao
            public List<Ao> GetListAo()
            {
                return db.Aos.ToList();
            }

            // Thêm ao mới
            public bool Them(Ao ao)
            {
                try
                {
                    db.Aos.Add(ao);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }

            public bool Sua(Ao aoMoi)
            {
                var aoDb = db.Aos.Find(aoMoi.AoID);
                if (aoDb == null) return false;
                aoDb.TenAo = aoMoi.TenAo;
                aoDb.DienTich = aoMoi.DienTich;
                aoDb.ViTri = aoMoi.ViTri;
                aoDb.LoaiAo = aoMoi.LoaiAo;
                return db.SaveChanges() > 0;
            }

            public bool Xoa(int id)
            {
                var ao = db.Aos.Find(id);
                if (ao == null) return false;
                db.Aos.Remove(ao);
                return db.SaveChanges() > 0;
            }
        }

    }
}
