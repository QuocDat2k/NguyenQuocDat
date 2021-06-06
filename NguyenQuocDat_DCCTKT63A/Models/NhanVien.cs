using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenQuocDat_DCCTKT63A.Models
{
    public class NhanVien
    {
        [Key]
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string MaNhanVien { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        public int MaPhongBan { get; set; }

        public virtual PhongBan PhongBan { get; set; }
    }
}