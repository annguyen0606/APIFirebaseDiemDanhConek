namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietXe")]
    public partial class ChiTietXe
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string IdKey { get; set; }

        [StringLength(200)]
        public string IdMauXe { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SoKhung { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string SoMay { get; set; }

        public long? IdNhaCungCap { get; set; }

        public long? IdKho { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        public int? IdCongTy { get; set; }

        public bool? DangKiem { get; set; }

        public bool? SoBaoHanh { get; set; }

        public int? IdLoaiXe { get; set; }
    }
}
