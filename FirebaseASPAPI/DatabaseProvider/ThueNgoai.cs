namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThueNgoai")]
    public partial class ThueNgoai
    {
        [Key]
        public int IdTheuNgoai { get; set; }

        [StringLength(200)]
        public string CongViec { get; set; }

        public double? TienThueNgoai { get; set; }

        public double? TienLayCuaKH { get; set; }

        public double? TienLai { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public int? IdCongTy { get; set; }

        public int? IdTho { get; set; }

        public long? IdBaoDuong { get; set; }

        public DateTime? NgaySuaChua { get; set; }

        [StringLength(20)]
        public string PhanTramTrietKhau { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienTrietKhau { get; set; }
    }
}
