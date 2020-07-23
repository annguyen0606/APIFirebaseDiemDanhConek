namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ThoDichVu_TienCongTho2
    {
        public int Id { get; set; }

        public int? IdTho { get; set; }

        public int? IdTienCong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySuaChua { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public int? IdCongTy { get; set; }

        public long? IdBaoDuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienCong { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienKhachTra { get; set; }

        [StringLength(20)]
        public string PhanTramTrietKhau { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienTrietKhau { get; set; }
    }
}
