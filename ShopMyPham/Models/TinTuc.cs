namespace ShopMyPham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinTuc")]
    public partial class TinTuc
    {
        [Key]
        public int MaTinTuc { get; set; }

        [Required]
        [StringLength(100)]
        public string TieuDe { get; set; }

        [Required]
        [StringLength(100)]
        public string TomTat { get; set; }

        [Required]
        [StringLength(100)]
        public string NoiDung { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string AnhTinTuc { get; set; }
    }
}
