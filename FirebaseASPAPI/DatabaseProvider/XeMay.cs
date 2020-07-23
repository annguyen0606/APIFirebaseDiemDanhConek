namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XeMay")]
    public partial class XeMay
    {
        [Key]
        [StringLength(50)]
        public string IDXe { get; set; }

        [Required]
        [StringLength(350)]
        public string TenXe { get; set; }

        public long HangSanXuat { get; set; }

        [StringLength(150)]
        public string DVT { get; set; }

        public int? IDCongTy { get; set; }

        [StringLength(250)]
        public string DoiXe { get; set; }

        public int? IdKey { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }
    }
}
