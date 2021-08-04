namespace ShopMyPham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietHoaDon = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        public int MaSP { get; set; }

        [Required]
        [StringLength(100)]
        public string TenSP { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string AnhDaiDien { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaMoi { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaCu { get; set; }

        [Required]
        [StringLength(100)]
        public string MoTa { get; set; }

        [Required]
        [StringLength(100)]
        public string XuatXu { get; set; }

        public double TrongLuong { get; set; }

        public int MaLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }

        public virtual LoaiSP LoaiSP { get; set; }
    }
}
