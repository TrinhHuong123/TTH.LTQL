using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TTH.LTQL.Models
{
    [Table("NHANVIENs")]
    public class NHANVIEN
    {
        [Key]
        public string MaNV { get; set; }

        public string TenNV { get; set; }
        public int SĐT { get; set; }
        public string DiaChi { get; set; }
        public string ChucVu { get; set; }
        public string PhongBan { get; set; }
        public DateTime NgaykiHD { get; set; }

        public virtual TRINHDO_CM TRINHDO_CMs { get; set; }
        public virtual BANGLUONG BANGLUONGs { get; set; }
        public virtual CHUCVU CHUCVUs { get; set; }
        public virtual BANGCHAMCONG BANGCHAMCONGs { get; set; }
        public virtual DUAN DUANs { get; set; }
        public virtual KHENTHUONG_KYLUAT KHENTHUONG_KYLUATs { get; set; }
        public virtual ICollection<PHONGBAN> PHONGBANs { get; set; }
    }
}