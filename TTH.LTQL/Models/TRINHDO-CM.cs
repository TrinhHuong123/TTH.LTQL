using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TTH.LTQL.Models
{
    [Table("TRINHDO-CMs")]
    public class TRINHDO_CM
    {
        [Key]
        public int STT { get; set; }

        public string TenNV { get; set; }
        public string MaNV { get; set; }
        public string TDCM { get; set; }
        public string TDNN { get; set; }
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}