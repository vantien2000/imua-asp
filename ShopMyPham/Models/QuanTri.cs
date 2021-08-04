namespace ShopMyPham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuanTri")]
    public partial class QuanTri
    {
        [Key]
        public int MaQT { get; set; }

        [Required]
        [StringLength(32)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(32)]
        public string MatKhau { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string AnhDaiDien { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        public bool LoaiTK { get; set; }
    }
}
