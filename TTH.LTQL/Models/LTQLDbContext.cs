using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TTH.LTQL.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }

        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<PHONGBAN> PHONGBANs { get; set; }
        public virtual DbSet<BANGLUONG> BANGLUONGs { get; set; }
        public virtual DbSet<BANGCHAMCONG> BANGCHAMCONGs { get; set; }
        public virtual DbSet<TRINHDO_CM> TRINHDO_CMs { get; set; }
        public virtual DbSet<KHENTHUONG_KYLUAT> KHENTHUONG_KYLUATs { get; set; }
        public virtual DbSet<DUAN> DUANs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<AccountModel> AccountModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.MaCV)
                .IsUnicode(false);

            modelBuilder.Entity<PHONGBAN>()
                .Property(e => e.MaPB)
                .IsUnicode(false);

            modelBuilder.Entity<BANGLUONG>()
                .Property(e => e.MaLuong)
                .IsUnicode(false);

            modelBuilder.Entity<TRINHDO_CM>()
                .Property(e => e.STT);

            modelBuilder.Entity<BANGCHAMCONG>()
                .Property(e => e.MaCC)
                 .IsUnicode(false);

            modelBuilder.Entity<DUAN>()
                .Property(e => e.MaDuAn)
                 .IsUnicode(false);

            modelBuilder.Entity<KHENTHUONG_KYLUAT>()
                .Property(e => e.SoQD);
                  

        }

        public System.Data.Entity.DbSet<TTH.LTQL.Models.THONGTIN> THONGTINs { get; set; }
    }
}
