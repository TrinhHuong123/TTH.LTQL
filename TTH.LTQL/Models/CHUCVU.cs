﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TTH.LTQL.Models
{
    [Table("CHUCVUs")]
    public class CHUCVU
    {
        [Key]
        public string MaCV { get; set; }

        public string TenCV { get; set; }
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}