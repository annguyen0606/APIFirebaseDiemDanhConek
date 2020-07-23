namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietBanXe")]
    public partial class ChiTietBanXe
    {
        [StringLength(50)]
        public string SoHoaDonBanXe { get; set; }

        [Key]
        public int IDKey { get; set; }

        [StringLength(50)]
        public string SoKhung { get; set; }

        [StringLength(50)]
        public string SoMay { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGiaVao { get; set; }

        [StringLength(10)]
        public string VAT { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaCoVAT { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public int? IdCongTy { get; set; }

        public int? IdKho { get; set; }

        [StringLength(50)]
        public string SoChungTu { get; set; }
    }
}
