namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietNhapXe")]
    public partial class ChiTietNhapXe
    {
        [StringLength(50)]
        public string SoHoaDonNhap { get; set; }

        [StringLength(50)]
        public string IdXe { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string SoKhung { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SoMay { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaNhap { get; set; }

        public int? IdMauXe { get; set; }

        public long? IdCongTy { get; set; }

        [StringLength(50)]
        public string SoChungTu { get; set; }

        public int? IdKey { get; set; }

        [StringLength(10)]
        public string VAT { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaCoVAT { get; set; }

        public bool? DangKiem { get; set; }

        public bool? SoBaoHanh { get; set; }

        public int? IdLoaiXe { get; set; }
    }
}
