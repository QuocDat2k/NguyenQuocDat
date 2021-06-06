using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenQuocDat_DCCTKT63A.Models
{
    public class PhongBan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhongBan { get; set; }

        [StringLength(50)]
        public string TenPhongBan { get; set; }

        public ICollection<NhanVien> NhanViens { get; set; }
    }
}