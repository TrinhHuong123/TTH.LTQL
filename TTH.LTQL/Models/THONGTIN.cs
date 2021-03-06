using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TTH.LTQL.Models
{
    [Table("THONGTINs")]
    public class THONGTIN
    {
        [Key]
        public string ThongtinID { get; set; }

        public string Tieude { get; set; }   
        [AllowHtml]
        public string NoiDung{ get; set; }
    }
}